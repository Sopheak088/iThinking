using System;
using ProjectManagement.BaseObject;
namespace ProjectManagement.Branch.Entity
{
	public class BranchEntity : BaseClass
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public bool Active { get; set; }
        public Guid CompanyId { get; set; }
    }
}
