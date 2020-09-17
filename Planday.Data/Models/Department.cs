using System;
using System.Collections.Generic;

namespace Planday.Data.Models
{
    public partial class Department
    {
        public Guid Id { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentLocation { get; set; }
        public bool? Status { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DmlactionDate { get; set; }
    }
}
