using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgGame.Command.Application.Models;
using RpgGame.Infrastructre.Abstractions;

namespace RpgGame.Command.Application.Handlers
{
    public class WearItemHandler : INotificationHandler<WearItemRequestDto>
    {
        private readonly IItemRepository _itemRepository;

        public WearItemHandler(IItemRepository itemRepository) => _itemRepository = itemRepository;

        public async Task Handle(WearItemRequestDto notification, CancellationToken cancellationToken)
        {
            await _itemRepository.UpdateAsync(notification.CharacterId, notification.Item, notification.BodyPart);
        }
    }
}