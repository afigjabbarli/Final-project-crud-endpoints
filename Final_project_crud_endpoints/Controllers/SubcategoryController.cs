using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Subcategory;
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
    [Route("api/v1/subcategories")]
    public class SubcategoryController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;

        public SubcategoryController(DataContext data_context, IVerificationService verification_service, IFileService file_service)
        {
            _data_context = data_context;
            _verification_service = verification_service;
            _file_service = file_service;

        }
        [HttpPost("post")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([FromForm] SubcategoryPostDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subcategory = new Subcategory
            {
                Name = DTO.Name,
                Description = DTO.Description,
                Current_Category_Id = DTO.Current_Category_Id,
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                Subcategory_Code = _verification_service.RandomPasswordGenerator(Prefix.SUBCATEGORY)
            };

            subcategory.Phisical_image_name = await _file_service
                .UploadAsync(CustomUploadDirectories.Subcategories, DTO.File, subcategory.Subcategory_Code);

            try
            {
                await _data_context.Subcategories.AddAsync(subcategory);
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

            var URL = "https://localhost:7069/api/v1/subcategories/get/" + subcategory.Id;
            return Created(URL, JsonSerializer.Serialize(subcategory, jsonOptions));
        }
        [HttpGet("get-all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(typeof(List<SubcategoryListItemDTO>))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var subcategories = await _data_context.Subcategories.Select(s => new SubcategoryListItemDTO
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    Phisical_image_name = _file_service.ReadStaticFiles(s.Subcategory_Code, Contracts.CustomUploadDirectories.Subcategories, s.Phisical_image_name),
                    CreatedAt = s.CreatedAt,
                    LastUpdatedAt = s.LastUpdatedAt,
                    Subcategory_Code = s.Subcategory_Code,
                    Current_Category_Id = s.Current_Category_Id,
                }).ToListAsync();

                return Ok(subcategories);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        [HttpGet("get/{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces(typeof(SubcategoryListItemDTO))]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var subcategory = await _data_context.Subcategories.SingleOrDefaultAsync(sc => sc.Id.Equals(Id));
                if (subcategory is null)
                    return NotFound($"The category with the << {Id} >> number you are looking for does not already exist in the database!");

                var response = new SubcategoryListItemDTO
                {
                    Id = subcategory.Id,
                    Name = subcategory.Name,
                    Description = subcategory.Description,
                    CreatedAt = subcategory.CreatedAt,
                    LastUpdatedAt = subcategory.LastUpdatedAt,
                    Current_Category_Id = subcategory.Current_Category_Id,
                    Subcategory_Code = subcategory.Subcategory_Code,
                    Phisical_image_name = _file_service.ReadStaticFiles(subcategory.Subcategory_Code, CustomUploadDirectories.Subcategories, subcategory.Phisical_image_name)
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
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromForm] SubcategoryPostDTO DTO)
        {
            var subcategory = await _data_context.Subcategories.SingleOrDefaultAsync(sc => sc.Id.Equals(Id));
            if (subcategory is null) return NotFound($"The subcategory with this <<{Id}>> number was not found in the database!");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (DTO.File is not null)
            {
                _file_service.RemoveStaticFiles(subcategory.Subcategory_Code, CustomUploadDirectories.Subcategories, subcategory.Phisical_image_name);
                subcategory.Phisical_image_name = await _file_service.UploadAsync(CustomUploadDirectories.Subcategories, DTO.File, subcategory.Subcategory_Code);
            }

            subcategory.Name = DTO.Name;
            subcategory.Description = DTO.Description;
            subcategory.LastUpdatedAt = DateTime.UtcNow;
            subcategory.Current_Category_Id = DTO.Current_Category_Id;

            _data_context.Update(subcategory);
            await _data_context.SaveChangesAsync();
            return Ok(subcategory);
        }
        [HttpDelete("delete/{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var subcategory = await _data_context.Subcategories.SingleOrDefaultAsync(sc => sc.Id.Equals(Id));
            if (subcategory is null) { return NotFound($"The subcategory with the << {Id} >> number you are looking for does not already exist in the database!"); }

            try
            {
                if (subcategory.Phisical_image_name is not null)
                    _file_service.RemoveStaticFiles(subcategory.Subcategory_Code, CustomUploadDirectories.Subcategories, subcategory.Phisical_image_name);
                _data_context.Subcategories.Remove(subcategory);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return NoContent();
        }
        [HttpGet("search")]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [Produces(typeof(List<SubcategoryListItemDTO>))]
        public async Task<IActionResult> Search([FromQuery(Name = "query")] string query)
        {
            if (!CustomValidations.IsValidQueryString(query))
            {
                return BadRequest("The search query is invalid !!!");
            }

            var subcategories = await _data_context.Subcategories.ToListAsync();

            var result = subcategories.Where(sc => sc.Name
            .Contains(query, StringComparison.OrdinalIgnoreCase))
            .Select(sc => new SubcategoryListItemDTO
            {
                Id = sc.Id,
                Name = sc.Name,
                Description = sc.Description,
                Phisical_image_name = _file_service.ReadStaticFiles(sc.Subcategory_Code, Contracts.CustomUploadDirectories.Subcategories, sc.Phisical_image_name),
                CreatedAt = sc.CreatedAt,
                LastUpdatedAt = sc.LastUpdatedAt,
                Subcategory_Code = sc.Subcategory_Code,
                Current_Category_Id = sc.Current_Category_Id,
            }).ToList();

            return Ok(result);
        }

    }
}
