using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Repository
{
    public interface IBackeryRepository
    {
        Task<IEnumerable<Ban>> GetAllBans();
        Task AddBenAsync(Ban ban);
        Task AddRangeBenAsync(IEnumerable<Ban> bans);
        Task UpdateAllBans(IEnumerable<Ban> bans);
        Task DeleteAllBans();
    }
}