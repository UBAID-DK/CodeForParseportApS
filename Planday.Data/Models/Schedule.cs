using System;
using System.Collections.Generic;

namespace Planday.Data.Models
{
    public partial class Schedule
    {
        public Guid Id { get; set; }
        public int ScheduleId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ShiftId { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DmlactionDate { get; set; }
    }
}
