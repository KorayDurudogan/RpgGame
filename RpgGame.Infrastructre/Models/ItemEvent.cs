using System;
using MongoDB.Bson;
using RpgGame.Infrastructre.Enums;

namespace RpgGame.Infrastructre.Models
{
    public class ItemEvent
    {
        public ObjectId Id { get; set; }
        public string CharacterId { get; set; }
        public BodyParts BodyPart { get; set; }
        public string Item { get; set; }
        public DateTime Date { get; set; }
    }
}