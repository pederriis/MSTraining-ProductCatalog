using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTraining_ProductCatalog.Persistence.Models
{
    public class ProductEF
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
    }
}
