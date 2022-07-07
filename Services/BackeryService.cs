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
        private readonly RepositoryContext _context;
        private readonly TimeSpan _baseStep;
        public IEnumerable<Ban> State { get; set; }
        private BakerySimulator BakerySimulator { get; set; }


        public BackeryService(RepositoryContext context, TimeSpan baseStep)
        {
            _context = context;
            _baseStep = baseStep;
            BakerySimulator = new BakerySimulator(20);
        }

        private async Task SaveStateToDb()
        {
            _context.Bans.Add(State.ElementAt(0)); //todo change it
        }

        public void MakeStep(TimeSpan span)
        {
            foreach (var ban in State) ban.DropPrice(span);
        }
    }
}