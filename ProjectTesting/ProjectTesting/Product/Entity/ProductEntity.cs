using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.Product.Entity
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime MadeDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public byte[] Photo { get; set; }
        public bool Active { get; set; }
    }
}