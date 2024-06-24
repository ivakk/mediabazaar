using MP_BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesDal
{
    public interface IReplenishmentRequestDAL
    {
        List<ReplenishmentRequest> GetAllRequests();
        public void CreateRequest(ReplenishmentRequest request);
    }
}
