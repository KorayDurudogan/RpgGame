using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RpgGame.Command.Application.Models;
using RpgGame.Infrastructre.Abstractions;

namespace RpgGame.Command.Application.Handlers
{
    public class WearItemHandler : IRequestHandler<WearItemRequestDto>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public WearItemHandler(IItemRepository itemRepository, IMediator mediator, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(WearItemRequestDto notification, CancellationToken cancellationToken)
        {
            await _itemRepository.UpdateAsync(notification.CharacterId, notification.Item, notification.BodyPart);
            var itemWearedEvent = _mapper.Map<ItemWeared>(notification);
            await _mediator.Publish(itemWearedEvent, cancellationToken);
            return Unit.Value;
        }
    }
}