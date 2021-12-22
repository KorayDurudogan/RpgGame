using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RpgGame.Command.Api.Models;
using RpgGame.Command.Application.Models;

namespace RpgGame.Command.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        
        public ItemsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> SetItemEvent(WearItemRequest wearItemRequest)
        {
            var handlerRequest = _mapper.Map<WearItemRequestDto>(wearItemRequest);
            await _mediator.Send(handlerRequest);
            return Ok();
        }
    }
}