using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using RpgGame.Infrastructre.Abstractions;
using RpgGame.Infrastructre.Models;

namespace RpgGame.Infrastructre.Repositories
{
    public class ItemEventRepository : IItemEventRepository
    {
        private readonly IMongoCollection<ItemEvent> _itemEvents;
        
        public ItemEventRepository(IMongoClient client)
        {
            var database = client.GetDatabase("rpg");
            _itemEvents = database.GetCollection<ItemEvent>("ItemEvents");
        }

        public async Task InsertEventAsync(ItemEvent itemEvent) => await _itemEvents.InsertOneAsync(itemEvent);

        public async Task<List<ItemEvent>> GetSpecificTimeAsync(string characterId, DateTime date)
        {
            var characterIdFilter = Builders<ItemEvent>.Filter.Eq(c => c.CharacterId, characterId);
            var dateFilter = Builders<ItemEvent>.Filter.Lte(c => c.Date ,date);

            var events = await _itemEvents.Find(characterIdFilter & dateFilter).ToListAsync();
            return events;
        }
    }
}