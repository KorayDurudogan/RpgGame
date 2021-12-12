using MongoDB.Bson;

namespace RpgGame.Infrastructre.Models
{
    public class Item
    {
        public ObjectId Id { get; set; }
        public string FKCharId { get; set; }
        public string Feets { get; set; }
        public string Legs { get; set; }
        public string Chest { get; set; }
        public string Hands { get; set; }
        public string Head { get; set; }
        public string MainHand { get; set; }
        public string OffHand { get; set; }
      
    }
}