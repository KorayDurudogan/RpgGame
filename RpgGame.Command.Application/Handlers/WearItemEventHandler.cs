using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RpgGame.Command.Application.Models;
using RpgGame.Infrastructre.Abstractions;
using RpgGame.Infrastructre.Models;

namespace RpgGame.Command.Application.Handlers
{
    public class WearItemEventHandler : INotificationHandler<ItemWeared>
    {
        private readonly IItemEventRepository _itemEventRepository;
        private readonly IMapper _mapper;

        public WearItemEventHandler(IItemEventRepository itemEventRepository, IMapper mapper)
        {
            _itemEventRepository = itemEventRepository;
            _mapper = mapper;
        }

        public async Task Handle(ItemWeared notification, CancellationToken cancellationToken)
        {
            var itemEvent = _mapper.Map<ItemEvent>(notification);
            await _itemEventRepository.InsertEventAsync(itemEvent);
        }
    }
}