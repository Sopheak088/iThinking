using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.User.Entity
{
    internal class UserEntity
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Position { get; set; }
    }
}