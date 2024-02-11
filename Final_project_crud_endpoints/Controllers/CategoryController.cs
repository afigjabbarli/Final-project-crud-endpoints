using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Category;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IFileService _file_service;
        private readonly IVerificationService _verification_service;
        public CategoryController(DataContext data_context, IFileService file_service, IVerificationService verification_service)
        {
            _data_context = data_context;
            _file_service = file_service;
            _verification_service = verification_service;
        }
        [HttpPost("post")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([FromForm] CategoryPostDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = new Category
            {
                Name = DTO.Name,
                Description = DTO.Description,
                Category_Code = _verification_service.RandomPasswordGenerator(Contracts.Prefix.CATEGORY),
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
            };
            category.Phisical_image_name = await _file_service.UploadAsync(Contracts.CustomUploadDirectories.Categories, DTO.File, category.Category_Code);

            try
            {
                await _data_context.Categories.AddAsync(category);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            var jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            var URL = "https://localhost:7069/api/v1/categories/get/" + category.Id;
            return Created(URL, JsonSerializer.Serialize(category, jsonOptions));
        }
        [HttpGet("get-all")]
        [Produces(typeof(List<CategoryListItemDTO>))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categories = await _data_context.Categories.Select(c => new CategoryListItemDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Phisical_image_name = _file_service.ReadStaticFiles(c.Category_Code, Contracts.CustomUploadDirectories.Categories, c.Phisical_image_name),
                    CreatedAt = c.CreatedAt,
                    LastUpdatedAt = c.LastUpdatedAt,
                    Category_Code = c.Category_Code
                }).ToListAsync();
                return Ok(categories);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        [HttpGet("get/{Id}")]
        [Produces(typeof(CategoryListItemDTO))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var category = await _data_context.Categories.SingleOrDefaultAsync(c => c.Id.Equals(Id));
                if (category is null)
                {
                    return NotFound($"The category with the << {Id} >> number you are looking for does not already exist in the database!");
                }

                var response = new CategoryListItemDTO
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,
                    Phisical_image_name = _file_service.ReadStaticFiles(category.Category_Code, Contracts.CustomUploadDirectories.Categories, category.Phisical_image_name),
                    CreatedAt = category.CreatedAt,
                    LastUpdatedAt = category.LastUpdatedAt,
                    Category_Code = category.Category_Code
                };
                return Ok(response);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        [HttpPut("update/{Id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromForm] CategoryPostDTO DTO)
        {
            var category = await _data_context.Categories.SingleOrDefaultAsync(c => c.Id.Equals(Id));
            if(category is null)
            {
                return NotFound($"The category with this <<{Id}>> number was not found in the database!");  
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(DTO.File is not null)
            {
                _file_service.RemoveStaticFiles(category.Category_Code, Contracts.CustomUploadDirectories.Categories, category.Phisical_image_name);
                category.Phisical_image_name = await _file_service.
                    UploadAsync(Contracts.CustomUploadDirectories.Categories, DTO.File!, category.Category_Code);   
            }

            category.Name = DTO.Name;
            category.Description = DTO.Description;
            category.LastUpdatedAt = DateTime.UtcNow;
            
            _data_context.Categories.Update(category);
            await _data_context.SaveChangesAsync();
            return Ok(category);
        }
        [HttpDelete("delete/{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var category = await _data_context.Categories.SingleOrDefaultAsync(c => c.Id.Equals(Id));
            if (category is null)
            {
                return NotFound($"The category with the << {Id} >> number you are looking for does not already exist in the database!");
            }
            try
            {
                _data_context.Categories.Remove(category);
                if(category.Phisical_image_name is not null)
                _file_service.RemoveStaticFiles(category.Category_Code, Contracts.CustomUploadDirectories.Categories, category.Phisical_image_name);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return NoContent();
        }
        //[HttpGet("get-all-categories")]
        //public async Task<IActionResult> GetAllCategories()
        //{
        //    try
        //    {
        //        var categories = await _data_context.Subcategories.ToListAsync();
        //        foreach (var category in categories)
        //        {
        //            category.Subcategory_Code = _verification_service.RandomPasswordGenerator(Prefix.SUBCATEGORY);
        //        }

        //        await _data_context.SaveChangesAsync(); // Tüm kategorileri güncelle

        //        return Ok(categories);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Hata durumunu işle
        //        return StatusCode(500, "Bir hata oluştu. Kategoriler alınamadı.");
        //    }
        //}

    }
}
