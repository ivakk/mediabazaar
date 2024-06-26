using MP_BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesLL
{
    public interface IReplenishmentRequestService
    {
        void CreateRequest(ReplenishmentRequest request);
        void UpdateRequest(ReplenishmentRequest request);
        List<ReplenishmentRequest> GetAllRequests();
        List<ReplenishmentRequest> GetRequestsByProductId(int productId);

    }
}
