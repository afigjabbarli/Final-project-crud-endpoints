using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Product;
using Final_project_crud_endpoints.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/quality-levels")]    
    public class ProductQualityLevelController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly ILogger<ProductQualityLevelController> _logger;
        public ProductQualityLevelController(DataContext data_context, ILogger<ProductQualityLevelController> logger)
        {
            _data_context = data_context;
            _logger = logger;
        }
        [HttpGet("get-all")]
        [Produces(type: typeof(List<QualityLevel>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var response = await _data_context.QualityLevels.OrderBy(ql => ql.CreatedAt).ToListAsync();

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
