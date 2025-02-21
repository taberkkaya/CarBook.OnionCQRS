using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly CreateAboutCommandHandler _createAboutCommandHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetAboutQueryHandler _getAboutQueryHandler;
        private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;
        private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;

        public AboutsController(
            CreateAboutCommandHandler createAboutCommandHandler, 
            GetAboutByIdQueryHandler getAboutByIdQueryHandler, 
            GetAboutQueryHandler getAboutQueryHandler, 
            RemoveAboutCommandHandler removeAboutCommandHandler, 
            UpdateAboutCommandHandler updateAboutCommandHandler)
        {
            _createAboutCommandHandler = createAboutCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
            _removeAboutCommandHandler = removeAboutCommandHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id)); 
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _createAboutCommandHandler.Handle(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(RemoveAboutCommand command)
        {
            await _removeAboutCommandHandler.Handle(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await _updateAboutCommandHandler.Handle(command);
            return Ok();
        }
    }
}
