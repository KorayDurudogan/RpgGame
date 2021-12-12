using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RpgGame.Infrastructre.Models;

namespace RpgGame.Infrastructre.Abstractions
{
    public interface IItemEventRepository
    {
        Task InsertEventAsync(ItemEvent itemEvent);

        Task<List<ItemEvent>> GetSpecificTimeAsync(string characterId, DateTime date);
    }
}