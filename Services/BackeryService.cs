using System;
using System.Collections.Generic;
using Entities;

namespace Services
{
    public class BackeryService : IBackeryService
    {
        public IEnumerable<Ban> State { get; set; }
        public TimeSpan BaseStep { get; set; }
        private BakerySimulator BakerySimulator { get; set; }

        public BackeryService(TimeSpan baseStep)
        {
            BakerySimulator = new BakerySimulator(20);
        }

        public void MakeStep(TimeSpan span)
        {
            foreach (var ban in State) ban.DropPrice(span);
        }
    }}