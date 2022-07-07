using System;

namespace Entities
{
    public class Croissant : Ban
    {
        private Croissant()
        {
            
        }
        public Croissant(TimeSpan dropTime, TimeSpan controlSaleTime, decimal startPrice) : base(
            dropTime,
            controlSaleTime, startPrice)
        {
        }
    }
}