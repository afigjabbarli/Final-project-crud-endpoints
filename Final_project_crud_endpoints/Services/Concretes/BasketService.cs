using Final_project_crud_endpoints.Contracts.Templates;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Basket;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using System.Text.Json;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class BasketService : IBasketService
    {
        private readonly IHttpContextAccessor _http_context_accessor;
        private readonly IUserService _user_service;
        private readonly DataContext _data_context;
        private readonly IFileService _file_service;
        public BasketService(IHttpContextAccessor httpContextAccessor, IUserService user_service, DataContext data_context, IFileService file_service)
        {
            _http_context_accessor = httpContextAccessor;
            _user_service = user_service;
            _data_context = data_context;
            _file_service = file_service;
        }
        public BasketItem AppendProductToBasket(BasketCookieItem basket_cookie_item)
        {
            List<BasketCookieItem> basket_cookie_items_list = new List<BasketCookieItem>();
            BasketItem basket_item = new BasketItem();

            var cookie_basket_value = _http_context_accessor.HttpContext.Request.Cookies[CookieNames.BasketItems.ToString()];
            var basket_items_data = _data_context.BasketItems.Where(bi => bi.Current_User_ID
            .Equals(_user_service.CurrentUser.Id)).ToList();

            if (cookie_basket_value is null && basket_items_data.Count == 0)
            {
                basket_cookie_items_list.Add(basket_cookie_item);

                basket_item = ConstructBasketItem(basket_cookie_item);
            }

            if (cookie_basket_value is null && basket_items_data.Count > 0)
            {
                basket_cookie_items_list.Add(basket_cookie_item);

                basket_cookie_items_list = SyncBasketCookieItemsWithCookieData(basket_cookie_items_list, basket_items_data);

                basket_item = ConstructBasketItem(basket_cookie_item);
            }

            if (cookie_basket_value is not null && basket_items_data.Count > 0)
            {
                basket_cookie_items_list = JsonSerializer.Deserialize<List<BasketCookieItem>>(cookie_basket_value);

                basket_cookie_items_list = basket_cookie_items_list.Count > 0 ? basket_cookie_items_list : new List<BasketCookieItem>();        

                if (basket_cookie_items_list.Count > 0 && basket_cookie_items_list
                    .Any(basket_cookie_item => basket_cookie_item.Current_User_Id != _user_service.CurrentUser.Id))
                {
                    ClearBasketItems();

                    basket_cookie_items_list.Add(basket_cookie_item);

                    basket_item = ConstructBasketItem(basket_cookie_item);
                }
                else
                {
                    if (basket_cookie_items_list.Any(basket_cookie_item => basket_cookie_item.ProductID.Equals(basket_cookie_item.ProductID))
                        && _data_context.BasketItems.Any(bi => bi.Product_ID.Equals(basket_cookie_item.ProductID)))
                    {
                        var exist_basket_item_data = _data_context.BasketItems.SingleOrDefault(bi => bi.Product_ID.Equals(basket_cookie_item.ProductID));
                        var exist_basket_item_cookie = basket_cookie_items_list.SingleOrDefault(bi => bi.ProductID.Equals(basket_cookie_item.ProductID));

                        if (exist_basket_item_cookie is not null && exist_basket_item_data is not null)
                        {
                            basket_cookie_items_list.Remove(exist_basket_item_cookie);
                            _data_context.BasketItems.Remove(_data_context.BasketItems.Single(bi => bi.Product_ID.Equals(exist_basket_item_data)));
                            BasketCookieItem updatedBasketCookieItem;
                            BasketItem updatedBasketItem;

                            UpdateBasketItem(exist_basket_item_cookie, exist_basket_item_data, basket_cookie_item, out updatedBasketCookieItem, out updatedBasketItem);

                            basket_cookie_items_list.Add(updatedBasketCookieItem);
                            basket_item = updatedBasketItem;
                        }
                    }
                    else
                    {
                        basket_cookie_items_list.Add(basket_cookie_item);

                        basket_item = ConstructBasketItem(basket_cookie_item);
                    }
                }
            }

            cookie_basket_value = JsonSerializer.Serialize(basket_cookie_items_list);
            _http_context_accessor.HttpContext.Response.Cookies.Append(CookieNames.BasketItems.ToString(), cookie_basket_value);

            return basket_item;
        }
        public List<BasketListItemDTO> FetchAllBasketItems()
        {
            var basket_items_cookie_value = _http_context_accessor.HttpContext.Request.Cookies[CookieNames.BasketItems.ToString()];

            var basket_cookie_items_list = basket_items_cookie_value != null
                ? JsonSerializer.Deserialize<List<BasketCookieItem>>(basket_items_cookie_value)
                : new List<BasketCookieItem>();
            
            if(basket_cookie_items_list.Count > 0 && basket_cookie_items_list.Any(bi => bi.Current_User_Id.Equals(_user_service.CurrentUser.Id)))
            {
                var DTOs = basket_cookie_items_list.Select(bi => new BasketListItemDTO
                {
                    Product_Name = bi.Product_Name, 
                    Phisical_image_URLs = _file_service
                    .ReadStaticFiles(bi.Product_Code, Contracts.CustomUploadDirectories.Products, bi.Phisical_image_names.ToList()).ToArray(),
                    Price = bi.Price,
                    Is_Aviable = bi.IsAviable,
                    Quantity = bi.Quantity,
                    Product_ID = bi.ProductID,
                    Warranty_IDs = bi.WarrantyIDs.ToArray(),
                    Size_IDs = bi.SizeIDs.ToArray(),
                    Store_IDs = bi.StoreIDs.ToArray(),
                    Color_IDs = bi.ColorIDs.ToArray(),

                }).ToList();

                return DTOs;
            }
            else
            {
                var DTOs = _data_context.BasketItems.Where(bi => bi.Current_User_ID.Equals(_user_service.CurrentUser.Id))
                    .Select(bi => new BasketListItemDTO
                    {
                        Product_Name = bi.Product_Name,
                        Phisical_image_URLs = _file_service
                        .ReadStaticFiles(bi.Product_Code, Contracts.CustomUploadDirectories.Products, bi.Phisical_image_names.ToList()).ToArray(),
                        Price= bi.Price,
                        Is_Aviable= bi.IsAviable,
                        Quantity= bi.Quantity,  
                        Product_ID= bi.Product_ID,
                        Warranty_IDs = bi.Warranty_IDs.ToArray(),
                        Store_IDs = bi.Store_IDs.ToArray(),
                        Color_IDs = bi.Color_IDs.ToArray(), 
                        Size_IDs = bi.Size_IDs.ToArray(),
                    }).ToList();

                return DTOs;    
            }
        }
        //private BasketCookieItem FindBasketCookieItemFromCookie(List<BasketCookieItem> basket_cookie_items, BasketCookieItem cookie_item)
        //{
        //    return cookie_item;
        //}
        private void UpdateBasketItem(BasketCookieItem basket_cookie_exist_item, BasketItem basket_cookie_exist_data,
            BasketCookieItem basket_cookie_item, out BasketCookieItem updatedBasketCookieItem, out BasketItem updatedBasketItem)
        {

            basket_cookie_exist_item.Price = basket_cookie_item.Price;
            basket_cookie_exist_item.Quantity = basket_cookie_item.Quantity;
            basket_cookie_exist_item.IsAviable = basket_cookie_item.IsAviable;
            basket_cookie_exist_item.ColorIDs = basket_cookie_item.ColorIDs;
            basket_cookie_exist_item.SizeIDs = basket_cookie_item.SizeIDs;
            basket_cookie_exist_item.StoreIDs = basket_cookie_item.StoreIDs;
            basket_cookie_exist_item.WarrantyIDs = basket_cookie_item.WarrantyIDs;

            basket_cookie_exist_data.Color_IDs = basket_cookie_item.ColorIDs.ToArray();
            basket_cookie_exist_data.Size_IDs = basket_cookie_item.SizeIDs.ToArray();
            basket_cookie_exist_data.Store_IDs = basket_cookie_item.StoreIDs.ToArray();
            basket_cookie_exist_data.Warranty_IDs = basket_cookie_item.WarrantyIDs.ToArray();
            basket_cookie_exist_data.LastUpdatedAt = DateTime.UtcNow;
            basket_cookie_exist_data.Quantity = basket_cookie_item.Quantity;
            basket_cookie_exist_data.IsAviable = basket_cookie_item.IsAviable;
            basket_cookie_exist_data.Price = basket_cookie_item.Price;

            updatedBasketCookieItem = basket_cookie_exist_item;
            updatedBasketItem = basket_cookie_exist_data;
        }
        public void ClearBasketItems()
        {
            _http_context_accessor.HttpContext.Response.Cookies.Delete(CookieNames.BasketItems.ToString());
        }
        private List<BasketCookieItem> SyncBasketCookieItemsWithCookieData(List<BasketCookieItem> basket_cookie_items, List<BasketItem> basket_items_data)
        {
            foreach (var basket_item_data in basket_items_data)
            {
                BasketCookieItem BasketCookieItem = new BasketCookieItem
                {
                    Current_User_Id = basket_item_data.Current_User_ID,
                    ProductID = basket_item_data.Product_ID,
                    Product_Name = basket_item_data.Product_Name,
                    Phisical_image_names = basket_item_data.Phisical_image_names,
                    Product_Code = basket_item_data.Product_Code,
                    Price = basket_item_data.Price,
                    Quantity = basket_item_data.Quantity,
                    IsAviable = basket_item_data.IsAviable,
                    ColorIDs = basket_item_data.Color_IDs.ToList(),
                    SizeIDs = basket_item_data.Size_IDs.ToList(),
                    WarrantyIDs = basket_item_data.Warranty_IDs.ToList(),
                    StoreIDs = basket_item_data.Store_IDs.ToList(),
                };

                basket_cookie_items.Add(BasketCookieItem);
            }

            return basket_cookie_items;
        }

        private BasketItem ConstructBasketItem(BasketCookieItem basket_cookie_item)
        {
            var basket_item = new BasketItem
            {
                Product_ID = basket_cookie_item.ProductID,
                Color_IDs = basket_cookie_item.ColorIDs.ToArray(),
                Size_IDs = basket_cookie_item.SizeIDs.ToArray(),
                Store_IDs = basket_cookie_item.StoreIDs.ToArray(),
                Warranty_IDs = basket_cookie_item.WarrantyIDs.ToArray(),
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                Quantity = basket_cookie_item.Quantity,
                IsAviable = basket_cookie_item.IsAviable,
                Product_Name = basket_cookie_item.Product_Name,
                Product_Code = basket_cookie_item.Product_Code,
                Phisical_image_names = basket_cookie_item.Phisical_image_names,
                Price = basket_cookie_item.Price,
                Current_User_ID = basket_cookie_item.Current_User_Id
            };

            return basket_item;
        }
    }
}
