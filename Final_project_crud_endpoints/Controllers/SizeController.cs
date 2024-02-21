using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/sizes")]
    public class SizeController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly ILogger<SizeController> _logger;
        public SizeController(DataContext data_context, ILogger<SizeController> logger)
        {
            _data_context = data_context;
            _logger = logger;
        }
        [HttpGet("get-all")]
        [Produces(type: typeof(List<Size>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var sizes = await _data_context.Sizes.ToListAsync();

                return Ok(sizes);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpGet("get/{Id}")]
        [Produces(type: typeof(Size))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var size = await _data_context.Sizes.SingleOrDefaultAsync(s => s.Id.Equals(Id));
                if (size is null) return NotFound($"The size with the << {Id} >> number you are looking for does not already exist in the database!");

                return Ok(size);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
    }
}
