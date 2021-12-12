using System.Threading.Tasks;
using RpgGame.Infrastructre.Enums;
using RpgGame.Infrastructre.Models;

namespace RpgGame.Infrastructre.Abstractions
{
    public interface IItemRepository
    {
        Task UpdateAsync(string charId, string armor, BodyParts bodyPart);

        Task<Item> GetAsync(string charId);
    }
}