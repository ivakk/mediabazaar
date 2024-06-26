using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Entities
{
    public class CheckStatus
    {
        public bool IsCheckedIn { get; set; }
        public DateTime? CheckTime { get; set; }
    }
}
