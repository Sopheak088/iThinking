using System;

namespace ProjectTesting.Company.Entity
{
    class CompanyEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public byte[] Logo { get; set; }
        public int Branch { get; set; }
        public CompanyEntity() { }

    }
}
