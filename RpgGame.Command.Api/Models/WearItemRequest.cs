using RpgGame.Infrastructre.Enums;

namespace RpgGame.Command.Api.Models
{
    public class WearItemRequest
    {
        public string CharacterId { get; set; }
        public BodyParts BodyPart { get; set; }
        public string Item { get; set; }
    }
}