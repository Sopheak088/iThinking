using ProjectManagement.BaseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Customer.Entity
{
    public class CustomerEntity : BaseClass
    {
        public Guid ID { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        public bool Active { get; set; }
        public string OtherContact { get; set; }
        public Guid MemberShipID { get; set; }
    }
}