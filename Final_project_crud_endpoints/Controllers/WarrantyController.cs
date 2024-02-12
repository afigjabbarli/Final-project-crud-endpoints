using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Warranty;
using Final_project_crud_endpoints.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/warranties")]
    public class WarrantyController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly ILogger<WarrantyController> _logger;
        public WarrantyController(DataContext data_context, ILogger<WarrantyController> logger)
        {
            _data_context = data_context;
            _logger = logger;
        }
        [HttpPost("post")]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status201Created)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Produces(type: typeof(Warranty))]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([FromForm] WarrantyPostDTO DTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var warranty = new Warranty()
            {
                Name = DTO.Name,
                Description = DTO.Description,
                ExpireYear = DTO.ExpireYear,
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow
            };

            try
            {
                await _data_context.Warranties.AddAsync(warranty);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }

            var jsonOptions = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.Preserve };

            var URL = "https://localhost:7069/api/v1/warranties/get/" + warranty.Id;
            return Created(URL, JsonSerializer.Serialize(warranty, jsonOptions));
        }
        [HttpGet("get-all")]
        [Produces(type: typeof(List<WarrantyListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var response = await _data_context.Warranties.Select(w => new WarrantyListItemDTO
                {
                    Id = w.Id,
                    Name = w.Name,
                    Description = w.Description,
                    CreatedAt = w.CreatedAt,
                    LastUpdatedAt = w.LastUpdatedAt,
                    ExpireYear = w.ExpireYear
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
        [Produces(type: typeof(WarrantyListItemDTO))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var warranty = await _data_context.Warranties.SingleOrDefaultAsync(w => w.Id.Equals(Id));

                if (warranty is null)
                    return NotFound($"The warranty with the << {Id} >> number you are looking for does not already exist in the database!");

                var response = new WarrantyListItemDTO
                {
                    Id = warranty.Id,
                    Name = warranty.Name,
                    Description = warranty.Description,
                    CreatedAt = warranty.CreatedAt,
                    LastUpdatedAt = warranty.LastUpdatedAt,
                    ExpireYear = warranty.ExpireYear
                };

                return Ok(response);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");
                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpPut("update/{Id}")]
        [Produces(type: typeof(Warranty))]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromForm] WarrantyPostDTO DTO)
        {
            try
            {
                var warranty = await _data_context.Warranties.SingleOrDefaultAsync(w => w.Id.Equals(Id));
                if(warranty is null)
                {
                    return NotFound($"The warranty with the << {Id} >> number you are looking for does not already exist in the database!");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);  
                }

                warranty.Name = DTO.Name;
                warranty.Description = DTO.Description; 
                warranty.ExpireYear = DTO.ExpireYear; 
                
                _data_context.Warranties.Update(warranty);
                await _data_context.SaveChangesAsync();

                return Ok(warranty);    
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
                var warranty = await _data_context.Warranties.SingleOrDefaultAsync(w => w.Id.Equals(Id));
                if(warranty is null)
                    return NotFound($"The warranty with the << {Id} >> number you are looking for does not already exist in the database!");

                _data_context.Warranties.Remove(warranty);
                await _data_context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");
                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
    }
}
