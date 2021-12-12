using System;
using MediatR;

namespace RpgGame.Query.Application.Models
{
    public class GetSpecificTimeItemSetRequestDto : IRequest<ItemQueryResponseDto>
    {
        public string CharacterId { get; set; }
        public DateTime Date { get; set; }
    }
}