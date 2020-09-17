using System;
using System.Collections.Generic;

namespace Planday.Data.Models
{
    public partial class Employee
    {
        public Guid Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneOrMobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public bool? Status { get; set; }
        public int? DepartmentId { get; set; }
        public int? ShiftId { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DmlactionDate { get; set; }
    }
}
