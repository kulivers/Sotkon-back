using System;
using System.Collections.Generic;
using Entities;

namespace Services
{
    public interface IBackeryService
    {
        IEnumerable<Ban> State { get; set; }
        void MakeStep(TimeSpan span);
    }
}