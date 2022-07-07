using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Record
    {
        
        public int Id { get; set; }

        public Ban Ban { get; set; }
        
        public DateTime Time { get; set; }
        
        [Column(TypeName = "money")]
        public decimal StartPrice { get; set; }
        
        [Column(TypeName = "money")]
        public decimal CurrentPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal NextPrice { get; set; }

        
        
    }
}