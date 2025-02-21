using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;

        public CarsController(
            CreateCarCommandHandler createCarCommandHandler, 
            GetCarByIdQueryHandler getCarByIdQueryHandler, 
            GetCarQueryHandler getCarQueryHandler, 
            RemoveCarCommandHandler removeCarCommandHandler, 
            UpdateCarCommandHandler updateCarCommandHandler)
        {
            _createCarCommandHandler = createCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);  
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(RemoveCarCommand command)
        {
            await _removeCarCommandHandler.Handle(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok();    
        }
    }
}
