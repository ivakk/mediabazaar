using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Entities
{
    public class ReplenishmentRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RequestedQuantity { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
    }

}
