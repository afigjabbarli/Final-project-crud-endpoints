using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Store;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/stores")]
    public class StoreController : ControllerBase
    {
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;
        private readonly ILogger<StoreController> _logger;
        private readonly DataContext _data_context;
        public StoreController(IVerificationService verification_service,
            IFileService file_service, ILogger<StoreController> logger, DataContext data_context)
        {
            _verification_service = verification_service;
            _file_service = file_service;
            _logger = logger;
            _data_context = data_context;
        }
        [HttpPost("post")]
        [ProducesResponseType(statusCode: StatusCodes.Status201Created)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post([FromForm] StorePostDTO DTO)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var store = new Store
            {
                Name = DTO.Name,
                Address = DTO.Address,
                Phone_Number = DTO.Phone_Number,
                State = DTO.State,
                Store_Code = _verification_service.RandomPasswordGenerator(Prefix.STORE),
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow
            };

            if (DTO.File is not null)
            {
                store.Phisical_image_name = await _file_service
                    .UploadAsync(CustomUploadDirectories.Stores, DTO.File, store.Store_Code);
            }

            try
            {
                await _data_context.Stores.AddAsync(store);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }

            var jsonOptions = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.Preserve };

            var URL = "https://localhost:7069/api/v1/stores/get/" + store.Id;
            return Created(URL, JsonSerializer.Serialize(store, jsonOptions));
        }
        [HttpGet("get/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Produces(type: typeof(StoreListItemDTO))] 
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                 var store = await _data_context.Stores.SingleOrDefaultAsync(s => s.Id.Equals(Id)); 
                 if(store is null)
                    return NotFound($"The store with the << {Id} >> number you are looking for does not already exist in the database!");

                var response = new StoreListItemDTO
                {
                    Id = store.Id,
                    Name = store.Name,
                    State = store.State,
                    Address = store.Address,
                    CreatedAt = store.CreatedAt,
                    LastUpdatedAt = store.LastUpdatedAt,
                    Phone_Number = store.Phone_Number,
                    Phisical_image_URL = _file_service.ReadStaticFiles(store.Store_Code, CustomUploadDirectories.Stores, store.Phisical_image_name)
                };

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
