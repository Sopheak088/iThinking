﻿using System;
using ProjectManagement.BaseObject;

namespace ProjectManagement.UserManagement.User.Entity
{
    public class UserEntity : BaseClass
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public Guid BranchId { get; set; }
    }
}