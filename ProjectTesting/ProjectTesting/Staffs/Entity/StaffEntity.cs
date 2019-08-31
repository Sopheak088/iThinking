using System;

namespace ProjectTesting.Staffs.Entity
{
    public class StaffEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime StopDate { get; set; }
        public byte[] Photo { get; set; }
    }
}
