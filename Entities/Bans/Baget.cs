using System;

namespace Entities
{
    public class Baget : Ban
    {
        private Baget()
        {
            
        }
        public Baget(TimeSpan dropTime, TimeSpan controlSaleTime, decimal startPrice) : base(dropTime,
          controlSaleTime, startPrice)
        {
        }
    }
}