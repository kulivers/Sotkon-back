using System.Collections.Generic;

namespace Entities
{
    public struct StateWrapper
    {
        public IEnumerable<Ban> State { get; set; }
    }
}