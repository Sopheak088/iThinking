using ProjectManagement.BaseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.MemberShip.Entity
{
    internal class MemberShipEntity : BaseClass

    {
        public Guid ID { get; set; }
        public string MembershipType { get; set; }
        public int DiscountValue { get; set; }
        public string DiscountText { get; set; }
        public string Other { get; set; }
    }
}