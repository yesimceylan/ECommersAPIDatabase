using _2ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ETicaretAPI.Domain.Entities
{
    public  class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; } 
        public ICollection<Product> Products { get; set; }
        // 1 orderın birden fazla productı olabilir. 
        public Customer Customer { get; set; }
        // 1 orderın sadece bir müşterisi olabilir. 

    }
}
