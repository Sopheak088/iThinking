using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.BaseObject;

namespace ProjectManagement.UserAccount.User.Entity
{
    public class UserEntity : BaseClass
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}