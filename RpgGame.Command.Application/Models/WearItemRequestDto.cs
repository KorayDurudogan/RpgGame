using MediatR;
using RpgGame.Infrastructre.Enums;

namespace RpgGame.Command.Application.Models
{
    public class WearItemRequestDto : IRequest
    {
        public string CharacterId { get; set; }
        public BodyParts BodyPart { get; set; }
        public string Item { get; set; }
    }
}