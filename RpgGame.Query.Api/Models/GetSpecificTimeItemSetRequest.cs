using System;

namespace RpgGame.Query.Api.Models
{
    public class GetSpecificTimeItemSetRequest
    {
        public string CharacterId { get; set; }
        public DateTime Date { get; set; }
    }
}