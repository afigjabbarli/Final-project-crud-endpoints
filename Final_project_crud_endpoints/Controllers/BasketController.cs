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
        private readonly ILogger<BasketController> _logger;
        public BasketController(DataContext data_context, IUserService user_service, IBasketService basket_service, ILogger<BasketController> logger)
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

            if (product.Quantity < DTO.Quantity)
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

            var color = await _data_context.ProductColors
                .Where(pc => pc.Color_Id.Equals(DTO.ColorID) && pc.Product_Id.Equals(product.Id))
                .Select(pc => pc.Color).SingleOrDefaultAsync();
            if (color is null)
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                    CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                return BadRequest(ModelState);
            }

            var size = await _data_context.ProductSizes
                .Where(ps => ps.Size_Id.Equals(DTO.SizeID) && ps.Product_Id.Equals(product.Id))
                .Select(ps => ps.Size).SingleOrDefaultAsync();
            if (size is null)
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                    CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                return BadRequest(ModelState);
            }

            var warranty = await _data_context.ProductWarranties
                .Where(pw => pw.Warranty_Id.Equals(DTO.WarrantyID) && pw.Product_Id.Equals(product.Id))
                .Select(pw => pw.Warranty).SingleOrDefaultAsync();
            if (warranty is null)
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                    CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                return BadRequest(ModelState);
            }

            var store = await _data_context.ProductStores
                .Where(ps => ps.Store_Id.Equals(DTO.StoreID) && ps.Product_Id.Equals(product.Id))
                .Select(ps => ps.Store).SingleOrDefaultAsync();
            if (store is null)
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.BasketItemPost.ToString(),
                    CustomValidationErrors.Value.BASKET_ITEM_NULL_POSTED);

                return BadRequest(ModelState);
            }

            cookieItem.ColorID = color.Id;
            cookieItem.SizeID = size.Id;
            cookieItem.WarrantyID = warranty.Id;
            cookieItem.StoreID = store.Id;

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
        [HttpGet(template: "get/{ID}")]
        public IActionResult Get(Guid ID)
        {
            try
            {
                var DTO = _basket_service.FetchSingleBasketItem(ID);

                return Ok(DTO);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);  
            }
        }
        [HttpDelete(template: "delete/{ID}")]
        public IActionResult Delete(Guid ID)
        {
            try
            {
                _basket_service.ClearSingleBasketItemFromBasketData(ID);    
                return NoContent();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);
            }
        }
        [HttpDelete(template: "delete-all")]
        public IActionResult Delete()
        {
            _basket_service.ClearBasketItems();

            return NoContent();
        }
    }
}
