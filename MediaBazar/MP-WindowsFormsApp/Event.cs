using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_WindowsFormsApp
{
    public class Event
    {
        public int EventID { get; set; }
        public int ShiftID { get; set; }
        public string EmployeeName { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
        public string Comments { get; set; }
    }
}
