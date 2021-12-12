using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RpgGame.Infrastructre.Abstractions;
using RpgGame.Infrastructre.Enums;
using RpgGame.Query.Application.Models;

namespace RpgGame.Query.Application.Handlers
{
    public class GetSpecificTimeItemSethandler : IRequestHandler<GetSpecificTimeItemSetRequestDto, ItemQueryResponseDto>
    {
        private readonly IItemEventRepository _itemEventRepository;

        public GetSpecificTimeItemSethandler(IItemEventRepository itemEventRepository) => _itemEventRepository = itemEventRepository;

        public async Task<ItemQueryResponseDto> Handle(GetSpecificTimeItemSetRequestDto request, CancellationToken cancellationToken)
        {
            var events = await _itemEventRepository.GetSpecificTimeAsync(request.CharacterId, request.Date);

            var itemSet = new ItemQueryResponseDto();
            foreach (var itemEvent in events)
            {
                switch (itemEvent.BodyPart)
                {
                    case BodyParts.Chest: itemSet.Chest = itemEvent.Item; break;
                    case BodyParts.Feets: itemSet.Feets = itemEvent.Item; break;
                    case BodyParts.Head: itemSet.Head = itemEvent.Item; break;
                    case BodyParts.Hands: itemSet.Hands = itemEvent.Item; break;
                    case BodyParts.MainHand: itemSet.MainHand = itemEvent.Item; break;
                    case BodyParts.OffHand: itemSet.OffHand = itemEvent.Item; break;
                    case BodyParts.Legs: itemSet.Legs = itemEvent.Item; break;
                }
            }

            return itemSet;
        }
    }
}