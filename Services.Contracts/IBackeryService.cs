using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public interface IBackeryService
    {
        Task InitRandomBans();
        Task<IEnumerable<Ban>> GetBans();
        IEnumerable<Ban> State { get; set; }
        Task<IEnumerable<Ban>> MakeStepGetNextState(TimeSpan span);
        Task UpdateAllBans(IEnumerable<Ban> bans);
        Task DeleteAllBans();
    }
}