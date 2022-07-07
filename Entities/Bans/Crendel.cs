using System;

namespace Entities
{
    public class Crendel : Ban
    {
        private Crendel()
        {
            
        }
        public Crendel(TimeSpan dropTime, TimeSpan controlSaleTime, decimal startPrice) : base(dropTime,
            controlSaleTime, startPrice)
        {
        }

        public override void DropPrice(TimeSpan timeSpent)
        {
            if (IsDroped) return;
            ExistsTime += timeSpent;
            if(ExistsTime >= DropTime)
            {
                IsDroped = true;
                return;
            };
            if (ExistsTime >= ControlSaleTime) CurrentPrice /= 2;
        }
    }
}