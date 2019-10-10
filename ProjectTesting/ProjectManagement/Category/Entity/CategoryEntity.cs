using ProjectManagement.BaseObject;
using System;

namespace ProjectManagement.Category.Entity
{
    public class CategoryEntity : BaseClass
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string Other { get; set; }

    }
}