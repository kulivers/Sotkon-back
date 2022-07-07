﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class BakerySimulator
    {
        public IEnumerable<Ban> Bans { get; set; }

        public BakerySimulator(int bansCount)
        {
            Bans = GetRandomBans(bansCount);
        }
        private IEnumerable<Ban> GetRandomBans(int count)
        {
            //можно было сделать BansFactory, но просто так быстрее
            var bans = new Stack<Ban>();
            var rand = new Random();
            int r;
            for (var i = 0; i < count; i++)
            {
                r = rand.Next(100);
                switch (r)
                {
                    case < 25:
                        bans.Push(new Baget(new TimeSpan(17, 0, 0), new TimeSpan(2, 0, 0), 20m));
                        break;
                    case >= 25 and < 50:
                        bans.Push(new Crendel(new TimeSpan(25, 0, 0), new TimeSpan(4, 0, 0), 40m));
                        break;
                    case <= 75 and > 50:
                        bans.Push(new Croissant(new TimeSpan(20, 0, 0), new TimeSpan(4, 0, 0), 60m));
                        break;
                    case > 75 and <= 99:
                        bans.Push(new Smetannik(new TimeSpan(13, 0, 0), new TimeSpan(4, 0, 0), 60m));
                        break;
                }
            }
            return bans;
        }

        public void MakeStep(TimeSpan timeSpend)
        {
            foreach (var ban in Bans) ban.DropPrice(timeSpend);
        }
    }
}