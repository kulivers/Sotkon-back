using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Repository;

namespace Services
{
    public class BackeryService : IBackeryService
    {
        private readonly IBackeryRepository _repository;
        public IEnumerable<Ban> State { get; set; }


        public BackeryService(IBackeryRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<Ban>> GetBans()
        {
            return await _repository.GetAllBans();
        }

        public async Task InitRandomBans() => await _repository.AddRangeBenAsync(BakerySimulator.GetRandomBans(20));

        public async Task<IEnumerable<Ban>> MakeStepGetNextState(TimeSpan span)
        {
            var cur = await GetBans();
            var next = BakerySimulator.GetNextState(cur,span);
            await UpdateAllBans(next);
            return next;
        }

        public Task UpdateAllBans(IEnumerable<Ban> bans)
        {
            
        }

        public async Task DeleteAllBans()
        {
            await _repository.DeleteAllBans();
        }
    }
}