using System;
using System.Collections.Generic;

namespace Planday.Data.Models
{
    public partial class Weekdays
    {
        public Guid? Id { get; set; }
        public int WeekDaysId { get; set; }
        public DateTime? Date { get; set; }
        public string Monday { get; set; }
        public string Thuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? EmployeeId { get; set; }
        public bool? Status { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DmlactionDate { get; set; }
    }
}
