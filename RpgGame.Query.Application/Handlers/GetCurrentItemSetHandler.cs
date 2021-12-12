using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RpgGame.Infrastructre.Abstractions;
using RpgGame.Query.Application.Models;

namespace RpgGame.Query.Application.Handlers
{
    public class GetCurrentItemSetHandler : IRequestHandler<GetCurrentItemSetRequestDto, ItemQueryResponseDto>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public GetCurrentItemSetHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<ItemQueryResponseDto> Handle(GetCurrentItemSetRequestDto request, CancellationToken cancellationToken)
        {
            var itemSet = await _itemRepository.GetAsync(request.CharacterId);
            return _mapper.Map<ItemQueryResponseDto>(itemSet);
        }
    }
}