using ProjectManagement.BaseObject;
using System;

namespace ProjectManagement.Product.Entity
{
    public class ProductEntity:BaseClass
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime? MadeDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Barcode { get; set; }
        public byte[] Photo { get; set; }      
        public bool Active { get; set; }

    }
}
