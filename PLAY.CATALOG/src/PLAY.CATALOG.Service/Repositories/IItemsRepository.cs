using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PLAY.CATALOG.Service.Entities;

namespace PLAY.CATALOG.Service.Repositories
{
    public interface IItemsRepository
    {
        Task CreateAsync(Item entity);
        Task<IReadOnlyCollection<Item>> GetAllAsync();
        Task<Item> GetAsync(Guid id);
        Task RemoveAsync(Guid id);
        Task UpdateAsync(Item entity);
    }
}