using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Record
    {
        
        public int Id { get; set; }
      
        
        public DateTime Time { get; set; }
        
        public decimal StartPrice { get; set; }
        
        public decimal CurrentPrice { get; set; }

        public decimal NextPrice { get; set; }

        
        
    }
}