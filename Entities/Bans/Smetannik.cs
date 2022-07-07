using System;

namespace Entities
{
    public class Smetannik : Ban
    {
        private Smetannik()
        {
            
        }
        public Smetannik(TimeSpan dropTime, TimeSpan controlSaleTime, decimal startPrice) : base(
            dropTime,  controlSaleTime, startPrice)
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
            var existTime = ExistsTime.Hours >= 1 ? ExistsTime.Hours : 1;
            CurrentPrice -= CurrentPrice * 0.02m * existTime;
            if (CurrentPrice < 0) CurrentPrice = 0;
        }
    }
}