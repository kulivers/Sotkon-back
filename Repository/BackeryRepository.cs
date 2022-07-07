using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace Repository
{
    public class BackeryRepository : RepositoryBase<Ban>, IBackeryRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public BackeryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task<IEnumerable<Ban>> GetAllBans() => FindAll().AsEnumerable();

        public async Task AddBenAsync(Ban ban)
        {
            await CreateAsync(ban);
            await _repositoryContext.SaveChangesAsync();
        }

        public async Task AddRangeBenAsync(IEnumerable<Ban> bans)
        {
            await _repositoryContext.Set<Ban>().AddRangeAsync(bans);
            await _repositoryContext.SaveChangesAsync();
        }
        public async Task DeleteAllBans()
        {
            _repositoryContext.Set<Ban>().RemoveRange(await GetAllBans());
            await _repositoryContext.SaveChangesAsync();
        }
        public async Task UpdateAllBans(IEnumerable<Ban> bans) 
        {
            _repositoryContext.Set<Ban>().UpdateRange(bans);
            await _repositoryContext.SaveChangesAsync();
        }
        
    }
}