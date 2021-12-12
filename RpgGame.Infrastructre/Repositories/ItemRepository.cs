using System.Threading.Tasks;
using MongoDB.Driver;
using RpgGame.Infrastructre.Abstractions;
using RpgGame.Infrastructre.Enums;
using RpgGame.Infrastructre.Models;

namespace RpgGame.Infrastructre.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly IMongoCollection<Item> _items;
        
        public ItemRepository(IMongoClient client)
        {
            var database = client.GetDatabase("rpg");
            _items = database.GetCollection<Item>("Items");
        }

        public async Task UpdateAsync(string charId, string armor, BodyParts bodyPart)
        {
            var filter = Builders<Item>.Filter.Eq(c => c.FKCharId, charId);
            var update = Builders<Item>.Update.Set(bodyPart.ToString(), armor);
            await _items.UpdateOneAsync(filter, update);
        }

        public async Task<Item> GetAsync(string charId)
        {
            var filter = Builders<Item>.Filter.Eq(c => c.FKCharId, charId);
            return await _items.Find(filter).FirstOrDefaultAsync();
        }
    }
}