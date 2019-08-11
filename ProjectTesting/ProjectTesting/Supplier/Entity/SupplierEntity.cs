using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.Supplier.Entity
{
    internal class SupplierEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Descritp { get; set; }
        public byte[] Photo { get; set; }
    }
}