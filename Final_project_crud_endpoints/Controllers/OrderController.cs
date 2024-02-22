using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.CustomExceptions;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Order;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using System.Text.Json;
using System.Text.Json.Serialization;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IBasketService _basket_service;
        private readonly IUserService _user_service;
        private readonly IVerificationService _verification_service;
        private readonly DataContext _data_context;
        private readonly IEmailService _email_service;
        private readonly IOrderService _order_service;
        public OrderController(IBasketService basket_service,
        IUserService user_service, IVerificationService verification_service, DataContext data_context, IEmailService email_service, IOrderService order_service)
        {
            _basket_service = basket_service;
            _user_service = user_service;
            _verification_service = verification_service;
            _data_context = data_context;
            _email_service = email_service;
            _order_service = order_service;
        }

        [HttpPost(template: "create-order")]
        public async Task<IActionResult> Post()
        {
            List<OrderItem> Order_Items = new List<OrderItem>();
            OrderDetailsDTO orderDetailsDTO = new OrderDetailsDTO();    
            var basket_items_data = _basket_service.FetchAllBasketItems();
            decimal total = 0;
            Order order = new()
            {
                User_ID = _user_service.CurrentUser.Id,
                Current_Order_Status = OrderCurrentStatus.CREATED,
                Tracking_ID = _verification_service.RandomPasswordGenerator(Prefix.ORDER),
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
            };

            if (basket_items_data.Count == 0)
                throw new BasketNotImplementedException();

            foreach (var basket_item_data in basket_items_data)
            {
                var color = await _data_context.Colors.SingleOrDefaultAsync(c => c.Id.Equals(basket_item_data.ColorID));
                var size = await _data_context.Sizes.SingleOrDefaultAsync(s => s.Id.Equals(basket_item_data.SizeID));
                var warranty = await _data_context.Warranties.SingleOrDefaultAsync(w => w.Id.Equals(basket_item_data.WarrantyID));
                var store = await _data_context.Stores.SingleOrDefaultAsync(s => s.Id.Equals(basket_item_data.StoreID));
                var product = await _data_context.Products.SingleOrDefaultAsync(pr => pr.Id.Equals(basket_item_data.Product_ID));

                if (color != null && size != null && warranty != null && store != null && product != null)
                {
                    OrderItem Order_Item = new()
                    {
                        Order = order,
                        Product_ID = basket_item_data.Product_ID,
                        Product_Size_ID = size.Id,
                        Product_Color_ID = color.Id,
                        Product_Warranty_ID = warranty.Id,
                        Product_Store_ID = store.Id,
                        Quantity = basket_item_data.Quantity,
                        Order_Item_Single_Price = product.Price - (product.Discount != 0 ? ((product.Price * product.Discount) / 100) : 0),
                        Order_Item_Total_Price = (product.Price - (product.Discount != 0 ? ((product.Price * product.Discount) / 100) : 0)) * basket_item_data.Quantity,
                        Phisical_Image_Name = basket_item_data.Phisical_image_URLs.Length > 0 ? basket_item_data.Phisical_image_URLs[0] : string.Empty,
                        CreatedAt = DateTime.UtcNow,
                        LastUpdatedAt = DateTime.UtcNow,
                        Product_Code = product.Product_Code
                    };

                    OrderItemDetailsDTO orderItemDetailsDTO = new OrderItemDetailsDTO
                    {
                        Product_Code = product.Product_Code,
                        Product_Name = product.Name,
                        Brand_Name = _data_context.Brands.Single(br => br.Id.Equals(product.Current_Brand_Id)).Name,
                        Category_Name = _data_context.Deepcategories.Single(ctg => ctg.Id.Equals(product.Current_Deepcategory_Id)).Name,
                        Order_Item_Single_Price = Order_Item.Order_Item_Single_Price,
                        Order_Item_Total_Price = Order_Item.Order_Item_Total_Price,
                        Quantity = Order_Item.Quantity,
                        Phisical_Image_URL = Order_Item.Phisical_Image_Name,
                        CreatedAt = Order_Item.CreatedAt
                    };

                    orderDetailsDTO.Order_Item_Details_DTOs.Add(orderItemDetailsDTO);   

                    total += (product.Price - ((product.Price * product.Discount) / 100)) * basket_item_data.Quantity;

                    Order_Items.Add(Order_Item);
                }
            }

            order.OrderItems = Order_Items;
            order.Order_Total_Price = total;


            await _data_context.Orders.AddAsync(order);

            _basket_service.ClearBasketItems();
            _data_context.BasketItems
                .RemoveRange(_data_context.BasketItems
                .Where(bi => bi.Current_User_ID.Equals(_user_service.CurrentUser.Id)));

            await _data_context.SaveChangesAsync();

            orderDetailsDTO.Order_ID = order.Id;
            orderDetailsDTO.Order_Created_At = order.CreatedAt;
            orderDetailsDTO.Order_Tracking_Code = order.Tracking_ID;
            orderDetailsDTO.Current_Order_Status = order.Current_Order_Status;
            orderDetailsDTO.Current_User_Surname = _user_service.CurrentUser.Surname;
            orderDetailsDTO.Current_User_Name = _user_service.CurrentUser.Name; 
            orderDetailsDTO.Current_User_Email = _user_service.CurrentUser.Email;
            orderDetailsDTO.Current_User_Phone_Number = _user_service.CurrentUser.PhoneNumber;
            orderDetailsDTO.Summary_Total = order.Order_Total_Price;

            var htmlcontent = await _order_service.PrepareAndSendOrderInvoiceAsync(orderDetailsDTO);    

            var document = new PdfDocument();

            PdfGenerator.AddPdfPages(document, htmlcontent, PageSize.LargePost);

            byte[]? response = null;
            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(ms);
                response = ms.ToArray();
            }
            string Filename = "Invoice_" + order.Tracking_ID + ".pdf";
            return File(response, "application/pdf", Filename);

        }


    }
}
