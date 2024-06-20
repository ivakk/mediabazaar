using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Entities
{
    internal class EmployeeCheckRecord
    {
        public int RecordId { get; set; }
        public int UserId { get; set; }
        public DateTime CheckTime { get; set; }
        public bool IsCheckIn { get; set; }
    }
}
