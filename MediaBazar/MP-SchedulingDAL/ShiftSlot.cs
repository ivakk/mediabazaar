using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingDAL
{
    public class ShiftSlot
    {
        public List<ShiftSlot> Shifts { get; set; }
        public DateTime StartTime { get; set; }
        public int RequiredPersonel { get; set; }
    }
}
