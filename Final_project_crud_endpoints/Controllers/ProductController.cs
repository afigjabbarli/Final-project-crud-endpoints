using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Product;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Final_project_crud_endpoints.Validations;
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
                if (!ModelState.IsValid)
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

                if ((await _data_context.Brands.AnyAsync(br => br.Id.Equals(DTO.Current_Brand_Id))) is false)
                {
                    return NotFound($"The brand with the << {DTO.Current_Brand_Id} >> number you are looking for does not already exist in the database!");
                }

                product.Current_Brand_Id = DTO.Current_Brand_Id;

                if ((await _data_context.Deepcategories.AnyAsync(dp => dp.Id.Equals(DTO.Current_Deepcategory_Id))) is false)
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

                if (DTO.ColorIds.Length > 0)
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

                if (DTO.SizeIds.Length > 0)
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

                if (DTO.WarrantyIds.Length > 0)
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

                if (DTO.StoreIds.Length > 0)
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
        [HttpGet("get/{Id}")]
        [Produces(type: typeof(ProductListItemDTO))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var product = await _data_context.Products.SingleOrDefaultAsync(p => p.Id.Equals(Id));

                if (product is null)
                    return NotFound($"The product with the << {Id} >> number you are looking for does not already exist in the database!");

                var response = new ProductListItemDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Product_Code = product.Product_Code,
                    Quantity = product.Quantity,
                    IsAvailable = product.IsAvailable,
                    Discount = product.Discount,
                    IsOffer = product.IsOffer,
                    ManufacturedAt = product.ManufacturedAt,
                    CreatedAt = product.CreatedAt,
                    LastUpdatedAt = product.LastUpdatedAt,
                    Phisical_image_URLs = _file_service
                    .ReadStaticFiles(product.Product_Code, CustomUploadDirectories.Products, product.Phisical_image_names),

                    Current_Brand = _data_context.Brands
                    .SingleOrDefault(br => br.Id.Equals(product.Current_Brand_Id))!,

                    Current_Deepcategory = _data_context.Deepcategories
                    .SingleOrDefault(dp => dp.Id.Equals(product.Current_Deepcategory_Id))!,

                    Colors = await _data_context.ProductColors
                    .Where(pc => pc.Product_Id.Equals(product.Id))
                    .Select(pc => pc.Color).ToListAsync(),

                    Sizes = await _data_context.ProductSizes
                    .Where(ps => ps.Product_Id.Equals(product.Id))
                    .Select(ps => ps.Size).ToListAsync(),

                    Stores = await _data_context.ProductStores
                    .Where(ps => ps.Product_Id.Equals(product.Id))
                    .Select(ps => ps.Store).ToListAsync(),

                    Warranties = await _data_context.ProductWarranties
                    .Where(pw => pw.Product_Id.Equals(product.Id))
                    .Select(pw => pw.Warranty).ToListAsync(),
                };

                var jsonOptions = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.Preserve };

                return Ok(JsonSerializer.Serialize(response, jsonOptions));

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpPut("update/{Id}")]
        [Produces(type: typeof(Product))]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromForm] ProductPostDTO DTO)
        {
            try
            {
                var product = await _data_context.Products.SingleOrDefaultAsync(pr => pr.Id.Equals(Id));
                if (product is null)
                    return NotFound($"The product with the << {Id} >> number you are looking for does not already exist in the database!");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                product.Name = DTO.Name;
                product.Description = DTO.Description;
                product.Price = DTO.Price;
                product.Quantity = DTO.Quantity;
                product.Discount = DTO.Discount;
                product.ManufacturedAt = DTO.ManufacturedAt;
                product.LastUpdatedAt = DateTime.UtcNow;

                if ((await _data_context.Deepcategories.AnyAsync(dp => dp.Id.Equals(DTO.Current_Deepcategory_Id))) is false)
                {
                    return NotFound($"The deepcategory with the << {DTO.Current_Deepcategory_Id} >> number you are looking for does not already exist in the database!");
                }

                product.Current_Deepcategory_Id = DTO.Current_Deepcategory_Id;

                if ((await _data_context.Brands.AnyAsync(br => br.Id.Equals(DTO.Current_Brand_Id))) is false)
                {
                    return NotFound($"The brand with the << {DTO.Current_Brand_Id} >> number you are looking for does not already exist in the database!");
                }

                product.Current_Brand_Id = DTO.Current_Brand_Id;

                if (DTO.Files.Count > 0)
                {
                    _file_service
                        .RemoveStaticFiles(product.Product_Code,
                        CustomUploadDirectories.Products,
                        product.Phisical_image_names);

                    product.Phisical_image_names = await _file_service
                        .UploadAsync(CustomUploadDirectories.Products,
                        DTO.Files, product.Product_Code);
                }

                _data_context.Products.Update(product);

                if (DTO.ColorIds.Length > 0)
                {
                    var removeableProductColors = await _data_context.ProductColors
                        .Where(pc => pc.Product_Id.Equals(product.Id)).ToListAsync();

                    foreach (var colorId in DTO.ColorIds)
                    {
                        var color = await _data_context.Colors.SingleOrDefaultAsync(c => c.Id.Equals(colorId));
                        if (color is null)
                        {
                            return NotFound($"The color with the << {colorId} >> number you are looking for does not already exist in the database!");
                        }
                        var removableProductColor = removeableProductColors.SingleOrDefault(pc => pc.Color_Id.Equals(colorId));
                        if (removableProductColor is null)
                        {
                            var productColor = new ProductColor
                            {
                                Product_Id = product.Id,
                                Color_Id = colorId,
                            };
                            await _data_context.ProductColors.AddAsync(productColor);
                        }
                        else
                        {
                            removeableProductColors.Remove(removableProductColor);
                        }
                    }

                    _data_context.ProductColors.RemoveRange(removeableProductColors);
                }

                if (DTO.SizeIds.Length > 0)
                {
                    var removeableProductSizes = await _data_context.ProductSizes
                        .Where(ps => ps.Product_Id.Equals(product.Id)).ToListAsync();

                    foreach (var sizeId in DTO.SizeIds)
                    {
                        var size = await _data_context.Sizes.SingleOrDefaultAsync(s => s.Id.Equals(sizeId));
                        if (size is null)
                        {
                            return NotFound($"The size with the << {sizeId} >> number you are looking for does not already exist in the database!");
                        }

                        var removeableProductSize = removeableProductSizes.SingleOrDefault(ps => ps.Size_Id.Equals(sizeId));
                        if (removeableProductSize is null)
                        {
                            var productSize = new ProductSize
                            {
                                Product_Id = product.Id,
                                Size_Id = sizeId
                            };

                            await _data_context.ProductSizes.AddAsync(productSize);
                        }
                        else
                        {
                            removeableProductSizes.Remove(removeableProductSize);
                        }
                    }

                    _data_context.ProductSizes.RemoveRange(removeableProductSizes);
                }

                if (DTO.StoreIds.Length > 0)
                {
                    var removeableProductStores = await _data_context.ProductStores
                        .Where(ps => ps.Product_Id.Equals(product.Id)).ToListAsync();

                    foreach (var storeId in DTO.StoreIds)
                    {
                        var store = await _data_context.Stores.SingleOrDefaultAsync(s => s.Id.Equals(storeId));
                        if (store is null)
                        {
                            return NotFound($"The store with the << {storeId} >> number you are looking for does not already exist in the database!");
                        }

                        var removeableProductStore = removeableProductStores.SingleOrDefault(ps => ps.Store_Id.Equals(storeId));

                        if (removeableProductStore is null)
                        {
                            var productStore = new ProductStore
                            {
                                Product_Id = product.Id,
                                Store_Id = storeId
                            };

                            await _data_context.ProductStores.AddAsync(productStore);
                        }

                        else
                        {
                            removeableProductStores.Remove(removeableProductStore);
                        }
                    }

                    _data_context.ProductStores.RemoveRange(removeableProductStores);
                }

                if (DTO.WarrantyIds.Length > 0)
                {
                    var removeableProductWarranties = await _data_context.ProductWarranties
                        .Where(pw => pw.Product_Id.Equals(product.Id)).ToListAsync();

                    foreach (var warrantyId in DTO.WarrantyIds)
                    {
                        var warranty = await _data_context.Warranties.SingleOrDefaultAsync(w => w.Id.Equals(warrantyId));
                        if (warranty is null)
                        {
                            return NotFound($"The warranty with the << {warrantyId} >> number you are looking for does not already exist in the database!");
                        }

                        var removeableProductWarranty = removeableProductWarranties.SingleOrDefault(pw => pw.Warranty_Id.Equals(warrantyId));

                        if (removeableProductWarranty is null)
                        {
                            var productWarranty = new ProductWarranty
                            {
                                Product_Id = product.Id,
                                Warranty_Id = warrantyId,
                            };

                            await _data_context.ProductWarranties.AddAsync(productWarranty);
                        }

                        else
                        {
                            removeableProductWarranties.Remove(removeableProductWarranty);
                        }
                    }

                    _data_context.ProductWarranties.RemoveRange(removeableProductWarranties);
                }

                await _data_context.SaveChangesAsync();
                return Ok(product);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpDelete("delete/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            try
            {
                var product = await _data_context.Products.SingleOrDefaultAsync(pr => pr.Id.Equals(Id));
                if (product is null)
                    return NotFound($"The product with the << {Id} >> number you are looking for does not already exist in the database!");

                if (product.Phisical_image_names.Count > 0)
                {
                    _file_service
                       .RemoveStaticFiles(product.Product_Code, CustomUploadDirectories.Products, product.Phisical_image_names);
                }

                var removeableProductColors = await _data_context.ProductColors
                    .Where(pc => pc.Product_Id.Equals(product.Id)).ToListAsync();
                if (removeableProductColors.Count > 0)
                {
                    _data_context.ProductColors.RemoveRange(removeableProductColors);
                }

                var removeableProductSizes = await _data_context.ProductSizes
                    .Where(ps => ps.Product_Id.Equals(product.Id)).ToListAsync();
                if (removeableProductSizes.Count > 0)
                {
                    _data_context.ProductSizes.RemoveRange(removeableProductSizes);
                }

                var removeableProductStores = await _data_context.ProductStores
                    .Where(ps => ps.Product_Id.Equals(product.Id)).ToListAsync();
                if (removeableProductStores.Count > 0)
                {
                    _data_context.ProductStores.RemoveRange(removeableProductStores);
                }

                var removeableProductWarranties = await _data_context.ProductWarranties
                    .Where(pw => pw.Product_Id.Equals(product.Id)).ToListAsync();
                if (removeableProductWarranties.Count > 0)
                {
                    _data_context.ProductWarranties.RemoveRange(removeableProductWarranties);
                }

                _data_context.Products.Remove(product);
                await _data_context.SaveChangesAsync();

                return NoContent(); //Daha sonra bura qayit mutleq burda bezi ishler qalib...
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }

        [HttpGet("search")]
        [Produces(type: typeof(List<ProductListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Search([FromQuery(Name = "query")] string query)
        {
            try
            {
                if (!CustomValidations.IsValidQueryString(query))
                {
                    return BadRequest("The search query is invalid!");
                }

                var products = await _data_context.Products.ToListAsync();

                if (products.Count == 0)
                {
                    return Ok(new List<ProductListItemDTO>());
                }

                var response = products
                    .Where(pr => pr.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                    .Select(pr => new ProductListItemDTO
                    {
                        Id = pr.Id,
                        Name = pr.Name,
                        Description = pr.Description,
                        Price = pr.Price,
                        Product_Code = pr.Product_Code,
                        Quantity = pr.Quantity,
                        IsAvailable = pr.IsAvailable,
                        Discount = pr.Discount,
                        IsOffer = pr.IsOffer,
                        ManufacturedAt = pr.ManufacturedAt,
                        CreatedAt = pr.CreatedAt,
                        LastUpdatedAt = pr.LastUpdatedAt,
                        Phisical_image_URLs = _file_service
                         .ReadStaticFiles(pr.Product_Code, CustomUploadDirectories.Products, pr.Phisical_image_names),

                        Current_Deepcategory = _data_context.Deepcategories
                        .SingleOrDefault(dp => dp.Id.Equals(pr.Current_Deepcategory_Id))!,

                        Current_Brand = _data_context.Brands
                        .SingleOrDefault(br => br.Id.Equals(pr.Current_Brand_Id))!,

                        Colors = _data_context.ProductColors
                        .Where(pc => pc.Product_Id.Equals(pr.Id))
                        .Select(pc => pc.Color).ToList(),

                        Sizes = _data_context.ProductSizes
                        .Where(ps => ps.Product_Id.Equals(pr.Id))
                        .Select(ps => ps.Size).ToList(),

                        Stores = _data_context.ProductStores
                        .Where(ps => ps.Product_Id.Equals(pr.Id))
                        .Select(ps => ps.Store).ToList(),

                        Warranties = _data_context.ProductWarranties
                        .Where(pw => pw.Product_Id.Equals(pr.Id))
                        .Select(pw => pw.Warranty).ToList(),
                    }).ToList();

                var jsonOptions = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                };

                return Ok(JsonSerializer.Serialize(response, jsonOptions));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
    }
}
