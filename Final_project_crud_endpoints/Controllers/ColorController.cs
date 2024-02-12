using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/colors")]
    public class ColorController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly ILogger<ColorController> _logger;
        public ColorController(DataContext data_context, ILogger<ColorController> logger)
        {
            _data_context = data_context;
            _logger = logger;
        }
        [HttpGet("get-all")]
        [Produces(type: typeof(List<Color>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var colors = await _data_context.Colors.ToListAsync();

                return Ok(colors);
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
                var color = await _data_context.Colors.SingleOrDefaultAsync(c => c.Id.Equals(Id));

                if(color is null) return NotFound($"The color with the << {Id} >> number you are looking for does not already exist in the database!");

                return Ok(color);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
    }
}
