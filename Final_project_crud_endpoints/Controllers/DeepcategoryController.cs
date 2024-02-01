using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Deepcategory;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/deepcategories")]
    public class DeepcategoryController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;

        public DeepcategoryController(DataContext data_context, IVerificationService verification_service, IFileService file_service)
        {
            _data_context = data_context;
            _verification_service = verification_service;
            _file_service = file_service;
        }

        [HttpPost("post")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([FromForm] DeepcategoryPostDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deepcategory = new Deepcategory
            {
                Name = DTO.Name,
                Description = DTO.Description,
                Current_Subcategory_Id = DTO.Current_Subcategory_Id,
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                Deepcategory_Code = _verification_service.RandomPasswordGenerator(Prefix.DEEPCATEGORY)
            };

            deepcategory.Phisical_image_name = await _file_service
                .UploadAsync(CustomUploadDirectories.Deepcategories, DTO.File, deepcategory.Deepcategory_Code);

            try
            {
                await _data_context.Deepcategories.AddAsync(deepcategory);
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

            var URL = "https://localhost:7069/api/v1/deepcategories/get/" + deepcategory.Id;
            return Created(URL, JsonSerializer.Serialize(deepcategory, jsonOptions));
        }

        [HttpGet("get-all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(typeof(List<DeepcategoryListItemDTO>))]
        public async Task<IActionResult> Get()
        {
            try
            {
                var deepcategories = await _data_context.Deepcategories.Select(dc => new DeepcategoryListItemDTO
                {
                    Id = dc.Id,
                    Name = dc.Name,
                    Description = dc.Description,
                    Phisical_image_name = _file_service.ReadStaticFiles(dc.Deepcategory_Code, CustomUploadDirectories.Deepcategories, dc.Phisical_image_name),
                    CreatedAt = dc.CreatedAt,
                    LastUpdatedAt = dc.LastUpdatedAt,
                    Deepcategory_Code = dc.Deepcategory_Code,
                    Current_Subcategory_Id = dc.Current_Subcategory_Id,
                }).ToListAsync();

                return Ok(deepcategories);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [HttpGet("get/{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces(typeof(DeepcategoryListItemDTO))]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var deepcategory = await _data_context.Deepcategories.SingleOrDefaultAsync(dc => dc.Id.Equals(Id));
                if (deepcategory is null)
                    return NotFound($"The deepcategory with the << {Id} >> number you are looking for does not already exist in the database!");

                var response = new DeepcategoryListItemDTO
                {
                    Id = deepcategory.Id,
                    Name = deepcategory.Name,
                    Description = deepcategory.Description,
                    CreatedAt = deepcategory.CreatedAt,
                    LastUpdatedAt = deepcategory.LastUpdatedAt,
                    Current_Subcategory_Id = deepcategory.Current_Subcategory_Id,
                    Deepcategory_Code = deepcategory.Deepcategory_Code,
                    Phisical_image_name = _file_service.ReadStaticFiles(deepcategory.Deepcategory_Code, CustomUploadDirectories.Deepcategories, deepcategory.Phisical_image_name)
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
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromForm] DeepcategoryPostDTO DTO)
        {
            var deepcategory = await _data_context.Deepcategories.SingleOrDefaultAsync(dc => dc.Id.Equals(Id));
            if (deepcategory is null) return NotFound($"The deepcategory with this <<{Id}>> number was not found in the database!");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (DTO.File is not null)
            {
                _file_service.RemoveStaticFiles(deepcategory.Deepcategory_Code, CustomUploadDirectories.Deepcategories, deepcategory.Phisical_image_name);
                deepcategory.Phisical_image_name = await _file_service.UploadAsync(CustomUploadDirectories.Deepcategories, DTO.File, deepcategory.Deepcategory_Code);
            }

            deepcategory.Name = DTO.Name;
            deepcategory.Description = DTO.Description;
            deepcategory.LastUpdatedAt = DateTime.UtcNow;
            deepcategory.Current_Subcategory_Id = DTO.Current_Subcategory_Id;

            _data_context.Update(deepcategory);
            await _data_context.SaveChangesAsync();
            return Ok(deepcategory);
        }

        [HttpDelete("delete/{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var deepcategory = await _data_context.Deepcategories.SingleOrDefaultAsync(dc => dc.Id.Equals(Id));
            if (deepcategory is null) { return NotFound($"The deepcategory with the << {Id} >> number you are looking for does not already exist in the database!"); }

            try
            {
                if (deepcategory.Phisical_image_name is not null)
                    _file_service.RemoveStaticFiles(deepcategory.Deepcategory_Code, CustomUploadDirectories.Deepcategories, deepcategory.Phisical_image_name);
                _data_context.Deepcategories.Remove(deepcategory);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return NoContent();
        }

        [HttpGet("search")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces(typeof(List<DeepcategoryListItemDTO>))]
        public async Task<IActionResult> Search([FromQuery(Name = "query")] string query)
        {
            if (!IsValidQueryString(query))
            {
                return BadRequest("The search query is invalid!");
            }

            var deepcategories = await _data_context.Deepcategories.ToListAsync();

            var result = deepcategories.Where(dc => dc.Name
            .Contains(query, StringComparison.OrdinalIgnoreCase))
            .Select(dc => new DeepcategoryListItemDTO
            {
                Id = dc.Id,
                Name = dc.Name,
            }).ToList();

            return Ok(result);
        }

        private bool IsValidQueryString(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                return Regex.IsMatch(query, "^[a-zA-Z]+$");
            };
            return false;
        }
    }
}
