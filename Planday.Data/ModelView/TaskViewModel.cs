using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Threading.Tasks;

namespace PlandayApi.Core.ModelView
{
    public class TaskViewModel
    {
        public int WeekDaysId { get; set; }
        public string EmployeeName { get; set; }
        public string DayNameWithDate { get; set; }
        public string Monday { get; set; }
        public string Thuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

    }
}
