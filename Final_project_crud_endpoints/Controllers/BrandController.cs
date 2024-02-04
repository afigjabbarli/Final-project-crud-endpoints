using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Brand;
using Final_project_crud_endpoints.DataBase.DTOs.Email;
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
    [Route("api/v1/brands")]
    public class BrandController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;
        private readonly ILogger<BrandController> _logger;
        private readonly IEmailService _email_service;
        public BrandController(DataContext data_context, IVerificationService verification_service,
            IFileService file_service, ILogger<BrandController> logger, IEmailService email_service)
        {
            _data_context = data_context;
            _verification_service = verification_service;
            _file_service = file_service;
            _logger = logger;
            _email_service = email_service;
        }
        [HttpPost("post")]
        [ProducesResponseType(statusCode: StatusCodes.Status201Created)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([FromForm] BrandPostDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var brand = new Brand
            {
                Name = DTO.Name,
                Description = DTO.Description,
                Location = DTO.Location,
                Since = DTO.Since.ToUniversalTime(),
                Brand_Code = _verification_service.RandomPasswordGenerator(Prefix.BRAND),
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow
            };

            brand.Phisical_Logo_Name = await _file_service
                .UploadAsync(CustomUploadDirectories.Brands, DTO.File, brand.Brand_Code);

            try
            {
                await _data_context.Brands.AddAsync(brand);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }

            var jsonOptions = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.Preserve };

            var URL = "https://localhost:7069/api/v1/brands/get/" + brand.Id;
            return Created(URL, JsonSerializer.Serialize(brand, jsonOptions));
        }
        [HttpGet("get/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Produces(type: typeof(BrandListItemDTO))]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var brand = await _data_context.Brands.SingleOrDefaultAsync(br => br.Id.Equals(Id));
                if (brand is null)
                {
                    return NotFound($"The brand with the << {Id} >> number you are looking for does not already exist in the database!");
                }

                var response = new BrandListItemDTO
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    Description = brand.Description,
                    Phisical_Logo_URL = _file_service.ReadStaticFiles(brand.Brand_Code, CustomUploadDirectories.Brands, brand.Phisical_Logo_Name),
                    Brand_Code = brand.Brand_Code,
                    Since = brand.Since,
                    Location = brand.Location,
                    CreatedAt = brand.CreatedAt,
                    LastUpdatedAt = brand.LastUpdatedAt
                };

                return Ok(response);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }

        }

        [HttpGet("get-all")]
        [Produces(type: typeof(List<BrandListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var responses = await _data_context.Brands.Select(br => new BrandListItemDTO
                {
                    Id = br.Id,
                    Name = br.Name,
                    Description = br.Description,
                    Phisical_Logo_URL = _file_service.ReadStaticFiles(br.Brand_Code, CustomUploadDirectories.Brands, br.Phisical_Logo_Name),
                    Location = br.Location,
                    Since = br.Since,
                    CreatedAt = br.CreatedAt,
                    LastUpdatedAt = br.LastUpdatedAt,
                    Brand_Code = br.Brand_Code
                }).ToListAsync();

                return Ok(responses);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");
                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpPut("update/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromForm] BrandPostDTO DTO)
        {
            try
            {
                var brand = await _data_context.Brands.SingleOrDefaultAsync(br => br.Id.Equals(Id));
                if (brand is null) return NotFound($"The brand with this <<{Id}>> number was not found in the database!");

                if (!ModelState.IsValid) return BadRequest(ModelState);

                if (DTO.File is not null)
                {
                    _file_service.RemoveStaticFiles(brand.Brand_Code, CustomUploadDirectories.Brands, brand.Phisical_Logo_Name);
                    brand.Phisical_Logo_Name = await _file_service.UploadAsync(CustomUploadDirectories.Brands, DTO.File, brand.Brand_Code);
                }

                brand.Name = DTO.Name;
                brand.Description = DTO.Description;
                brand.Location = DTO.Location;
                brand.Since = DTO.Since;
                brand.LastUpdatedAt = DateTime.UtcNow;

                _data_context.Update(brand);
                await _data_context.SaveChangesAsync();

                return Ok(brand);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");
                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpDelete("delete/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            try
            {
                var brand = await _data_context.Brands.SingleOrDefaultAsync(br => br.Equals(Id));
                if (brand is null)
                    return NotFound($"The brand with this <<{Id}>> number was not found in the database!");

                if (brand.Phisical_Logo_Name is not null)
                {
                    _file_service.RemoveStaticFiles(brand.Brand_Code, CustomUploadDirectories.Brands, brand.Phisical_Logo_Name);

                    _data_context.Brands.Remove(brand);
                    await _data_context.SaveChangesAsync();
                }

                return NoContent();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");
                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpGet("search")]
        [Produces(type: typeof(List<BrandListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> Search([FromQuery(Name = "query")] string query)
        {
            if (!CustomValidations.IsValidQueryString(query))
            {
                return BadRequest("The search query is invalid !!!");
            }

            try
            {
                var brands = await _data_context.Brands.ToListAsync();

                var responses = brands.Where(br => br.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                    .Select(br => new BrandListItemDTO
                    {
                        Id = br.Id,
                        Name = br.Name,
                        Description = br.Description,
                        Phisical_Logo_URL = _file_service.ReadStaticFiles(br.Brand_Code, CustomUploadDirectories.Brands, br.Phisical_Logo_Name),
                        Location = br.Location,
                        Since = br.Since,
                        CreatedAt = br.CreatedAt,
                        LastUpdatedAt = br.LastUpdatedAt,
                        Brand_Code = br.Brand_Code

                    }).ToList();

                return Ok(responses);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");
                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Email(string recipient, string subject, string body)
        {
            await _email_service.SendEmailAsync(recipient, subject, body);
            return Ok();
        }
    }
}
