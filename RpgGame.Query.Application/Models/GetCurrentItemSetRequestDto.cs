using MediatR;

namespace RpgGame.Query.Application.Models
{
    public class GetCurrentItemSetRequestDto : IRequest<ItemQueryResponseDto>
    {
        public string CharacterId { get; set; }
    }
}