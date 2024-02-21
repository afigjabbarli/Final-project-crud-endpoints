using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Basket;
using Final_project_crud_endpoints.Errors;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/basket-items")]
    public class BasketController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IUserService _user_service;
        private readonly IBasketService _basket_service;
        private readonly ILogger _logger;
        public BasketController(DataContext data_context, IUserService user_service, IBasketService basket_service, ILogger logger)
        {
            _data_context = data_context;
            _user_service = user_service;
            _basket_service = basket_service;
            _logger = logger;
        }
        [HttpPost(template: "add-to-cart")]
        public async Task<IActionResult> Post([FromForm] BasketItemPostDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                    CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                return BadRequest(ModelState);
            }

            BasketCookieItem cookieItem = new BasketCookieItem();

            var product = await _data_context.Products.SingleOrDefaultAsync(pr => pr.Id.Equals(DTO.Product_ID));
            if (product is null)
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                    CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                return BadRequest(ModelState);
            }

            cookieItem.ProductID = product.Id;
            cookieItem.Product_Code = product.Product_Code;
            cookieItem.Quantity = DTO.Quantity;
            cookieItem.IsAviable = product.IsAvailable;
            cookieItem.Current_User_Id = _user_service.CurrentUser.Id;
            cookieItem.Price = product.Price * DTO.Quantity;
            cookieItem.Product_Name = product.Name;
            cookieItem.Phisical_image_names = product.Phisical_image_names;

            foreach (var ColorID in DTO.Color_IDs)
            {
                var color = await _data_context.ProductColors
                    .Where(pc => pc.Color_Id.Equals(ColorID) && pc.Product_Id.Equals(product.Id))
                    .Select(pc => pc.Color).SingleOrDefaultAsync();
                if (color is null)
                {
                    ModelState.Clear();
                    ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                        CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                    return BadRequest(ModelState);
                }

                cookieItem.ColorIDs.Add(color.Id);
            }

            foreach (var SizeID in DTO.Size_IDs)
            {
                var size = await _data_context.ProductSizes
                    .Where(ps => ps.Size_Id.Equals(SizeID) && ps.Product_Id.Equals(product.Id))
                    .Select(ps => ps.Size).SingleOrDefaultAsync();

                if (size is null)
                {
                    ModelState.Clear();
                    ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                        CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                    return BadRequest(ModelState);
                }

                cookieItem.SizeIDs.Add(size.Id);
            }

            foreach (var WarrantyID in DTO.Warranty_IDs)
            {
                var warranty = await _data_context.ProductWarranties
                    .Where(pw => pw.Warranty_Id.Equals(WarrantyID) && pw.Product_Id.Equals(product.Id))
                    .Select(pw => pw.Warranty).SingleOrDefaultAsync();

                if (warranty is null)
                {
                    ModelState.Clear();
                    ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                        CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                    return BadRequest(ModelState);
                }

                cookieItem.WarrantyIDs.Add(warranty.Id);
            }

            foreach (var StoreID in DTO.Store_IDs)
            {
                var store = await _data_context.ProductStores
                    .Where(ps => ps.Store_Id.Equals(StoreID) && ps.Product_Id.Equals(product.Id))
                    .Select(ps => ps.Store).SingleOrDefaultAsync();

                if (store is null)
                {
                    ModelState.Clear();
                    ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                        CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                    return BadRequest(ModelState);
                }

                cookieItem.StoreIDs.Add(store.Id);
            }

            var basket_item = _basket_service.AppendProductToBasket(cookieItem);

            await _data_context.BasketItems.AddAsync(basket_item);
            await _data_context.SaveChangesAsync();

            var jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            return Ok(JsonSerializer.Serialize(basket_item, jsonOptions));
        }
        [HttpGet(template: "get-all")]
        [Produces(type: typeof(List<BasketListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            try
            {
                return Ok(_basket_service.FetchAllBasketItems());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
    }
}
