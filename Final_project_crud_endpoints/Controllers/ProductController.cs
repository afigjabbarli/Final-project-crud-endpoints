using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Product;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;
        private readonly ILogger<ProductController> _logger;
        public ProductController(DataContext data_context, IVerificationService verification_service, IFileService file_service, ILogger<ProductController> logger)
        {
            _data_context = data_context;
            _verification_service = verification_service;
            _file_service = file_service;
            _logger = logger;
        }
        [HttpPost("post")]
        [Produces(type: typeof(Product))]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status201Created)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromForm] ProductPostDTO DTO)
        {
            try
            {
                if (ModelState.IsValid)
                    return BadRequest(ModelState);

                var product = new Product
                {
                    Name = DTO.Name,
                    Product_Code = _verification_service.RandomPasswordGenerator(Prefix.PRODUCT),
                    Description = DTO.Description,
                    Price = DTO.Price,
                    Quantity = DTO.Quantity,
                    Discount = DTO.Discount,
                    ManufacturedAt = DTO.ManufacturedAt,
                    CreatedAt = DateTime.UtcNow,
                    LastUpdatedAt = DateTime.UtcNow,
                };

                if((await _data_context.Brands.AnyAsync(br => br.Id.Equals(DTO.Current_Brand_Id))) is false)
                {
                    return NotFound($"The brand with the << {DTO.Current_Brand_Id} >> number you are looking for does not already exist in the database!");  
                }

                product.Current_Brand_Id = DTO.Current_Brand_Id;    

                if((await _data_context.Deepcategories.AnyAsync(dp => dp.Id.Equals(DTO.Current_Deepcategory_Id))) is false)
                {
                    return NotFound($"The brand with the << {DTO.Current_Deepcategory_Id} >> number you are looking for does not already exist in the database!");
                }

                product.Current_Deepcategory_Id = DTO.Current_Deepcategory_Id;

                if (DTO.Files.Count > 0)
                {
                    product.Phisical_image_names = await _file_service
                        .UploadAsync(CustomUploadDirectories.Products, DTO.Files, product.Product_Code);
                }

                await _data_context.Products.AddAsync(product);

                if(DTO.ColorIds.Length > 0)
                {
                    foreach (var ColorId in DTO.ColorIds)
                    {
                        var color = await _data_context.Colors.SingleOrDefaultAsync(c => c.Id.Equals(ColorId));
                        if (color is null)
                            return NotFound($"The color with the << {ColorId} >> number you are looking for does not already exist in the database!");

                        var product_color = new ProductColor
                        {
                            Color_Id = ColorId,
                            Product = product
                        };

                        await _data_context.ProductColors.AddAsync(product_color);
                    }
                }

                if(DTO.SizeIds.Length > 0)
                {
                    foreach (var SizeId in DTO.SizeIds)
                    {
                        var size = await _data_context.Sizes.SingleOrDefaultAsync(s => s.Id.Equals(SizeId));
                        if (size is null)
                            return NotFound($"The size with the << {SizeId} >> number you are looking for does not already exist in the database!");

                        var product_size = new ProductSize
                        {
                            Size_Id = SizeId,
                            Product = product
                        };

                        await _data_context.ProductSizes.AddAsync(product_size);
                    }
                }

                if(DTO.WarrantyIds.Length > 0)
                {
                    foreach (var WarrantyId in DTO.WarrantyIds)
                    {
                        var warranty = await _data_context.Warranties.SingleOrDefaultAsync(w => w.Id.Equals(WarrantyId));

                        if (warranty is null)
                            return NotFound($"The warranty with the << {WarrantyId} >> number you are looking for does not already exist in the database!");

                        var product_warranty = new ProductWarranty
                        {
                            Warranty_Id = WarrantyId,
                            Product = product
                        };

                        await _data_context.ProductWarranties.AddAsync(product_warranty);
                    }
                }

                if(DTO.StoreIds.Length > 0)
                {
                    foreach (var StoreId in DTO.StoreIds)
                    {
                        var store = await _data_context.Stores.SingleOrDefaultAsync(s => s.Id.Equals(StoreId));

                        if (store is null)
                            return NotFound($"The store with the << {StoreId} >> number you are looking for does not already exist in the database!");

                        var product_store = new ProductStore
                        {
                            Store_Id = StoreId,
                            Product = product
                        };

                        await _data_context.ProductStores.AddAsync(product_store);
                    }
                }

                await _data_context.SaveChangesAsync();

                var jsonOptions = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.Preserve };

                var URL = "https://localhost:7069/api/v1/products/get/" + product.Id;
                return Created(URL, JsonSerializer.Serialize(product, jsonOptions));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpGet("get-all")]
        [Produces(type: typeof(List<ProductListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var response = await _data_context.Products.Select(p => new ProductListItemDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Product_Code = p.Product_Code,
                    Quantity = p.Quantity,
                    IsAvailable = p.IsAvailable,
                    Discount = p.Discount,
                    IsOffer = p.IsOffer,
                    ManufacturedAt = p.ManufacturedAt,
                    CreatedAt = p.CreatedAt,
                    LastUpdatedAt = p.LastUpdatedAt,
                    Phisical_image_URLs = _file_service
                     .ReadStaticFiles(p.Product_Code, CustomUploadDirectories.Products, p.Phisical_image_names),

                    Current_Deepcategory = _data_context.Deepcategories
                    .SingleOrDefault(dp => dp.Id.Equals(p.Current_Deepcategory_Id))!,

                    Current_Brand = _data_context.Brands
                    .SingleOrDefault(br => br.Id.Equals(p.Current_Brand_Id))!,

                    Colors = _data_context.ProductColors
                    .Where(pc => pc.Product_Id.Equals(p.Id))
                    .Select(pc => pc.Color).ToList(),

                    Sizes = _data_context.ProductSizes
                    .Where(ps => ps.Product_Id.Equals(p.Id))
                    .Select(ps => ps.Size).ToList(),

                    Stores = _data_context.ProductStores
                    .Where(ps => ps.Product_Id.Equals(p.Id))
                    .Select(ps => ps.Store).ToList(),

                    Warranties = _data_context.ProductWarranties
                    .Where(pw => pw.Product_Id.Equals(p.Id))
                    .Select(pw => pw.Warranty).ToList(),

                }).ToListAsync();

                return Ok(response);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
    }
}
