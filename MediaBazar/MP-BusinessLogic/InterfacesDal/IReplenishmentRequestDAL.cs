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
        public List<ReplenishmentRequest> GetRequestsByProductId(int productId);
        List<ReplenishmentRequest> GetAllRequests();
        void CreateRequest(ReplenishmentRequest replenishmentRequest);
        void UpdateRequest(ReplenishmentRequest replenishmentRequest);
    }
}
