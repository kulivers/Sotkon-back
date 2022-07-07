using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public abstract class Ban
    {
        protected Ban()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public TimeSpan ExistsTime { get; set; }
        public TimeSpan DropTime { get; set; }
        public bool IsDroped { get; set; } = false;
        [Column(TypeName = "money")] 
        public TimeSpan ControlSaleTime { get; set; } //контрольный срок продажи
        [Column(TypeName = "money")] public decimal StartPrice { get; set; }
        [Column(TypeName = "money")] public decimal CurrentPrice { get; set; }

        public virtual void DropPrice(TimeSpan timeSpent)
        {
            if (IsDroped)
                return;
            ExistsTime += timeSpent;
            if (ExistsTime >= DropTime)
            {
                IsDroped = true;
                return;
            }

            ;
            CurrentPrice -= StartPrice * 0.02m;
            if (CurrentPrice < 0) CurrentPrice = 0;
        }

        protected Ban(TimeSpan dropTime, TimeSpan controlSaleTime, decimal startPrice)
        {
            if (startPrice > 100)
                throw new Exception("Price cant be more than 100 rubles");
            if (StartPrice < 0)
                throw new Exception("Price cant be <=0");
            DropTime = dropTime;
            ControlSaleTime = controlSaleTime;
            IsDroped = false;
            StartPrice = startPrice;
            CurrentPrice = startPrice;
            ExistsTime = new TimeSpan(0, 0, 0);
        }
    }
}