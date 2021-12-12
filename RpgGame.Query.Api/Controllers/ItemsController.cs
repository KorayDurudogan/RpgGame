using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RpgGame.Query.Api.Models;
using RpgGame.Query.Application.Models;

namespace RpgGame.Query.Api.Controllers
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

        [HttpGet("current")]
        public async Task<IActionResult> GetCurrent([FromQuery] GetCurrentItemSetRequest request)
        {
            var mappedRequest = _mapper.Map<GetCurrentItemSetRequestDto>(request);
            var itemSet = await _mediator.Send(mappedRequest);
            return Ok(itemSet);
        }
        
        [HttpGet("specific-time")]
        public async Task<IActionResult> GetSpecificTime([FromQuery] GetSpecificTimeItemSetRequest request)
        {
            var mappedRequest = _mapper.Map<GetSpecificTimeItemSetRequestDto>(request);
            var itemSet = await _mediator.Send(mappedRequest);
            return Ok(itemSet);
        }
    }
}