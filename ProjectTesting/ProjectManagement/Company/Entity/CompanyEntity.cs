using System;
using ProjectManagement.BaseObject;

namespace ProjectManagement.Company.Entity
{
    public class CompanyEntity : BaseClass
    {
        public Guid Id { get; set; }
        public string NameInKhmer { get; set; }
        public string NameInEnglish { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public bool Active { get; set; }
        public byte[] Logo { get; set; }
    }
}