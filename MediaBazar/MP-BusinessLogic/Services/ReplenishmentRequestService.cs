using MP_BusinessLogic.Entities;
using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Services
{
    public class ReplenishmentRequestService : IReplenishmentRequestService
    {
        private readonly IReplenishmentRequestDAL replenishmentRequestDAL;

        public ReplenishmentRequestService(IReplenishmentRequestDAL replenishmentRequestDAL)
        {
            this.replenishmentRequestDAL = replenishmentRequestDAL;
        }
        public List<ReplenishmentRequest> GetAllRequests()
        {
            return replenishmentRequestDAL.GetAllRequests();
        }
        public void CreateRequest(ReplenishmentRequest replenishmentRequest)
        {
            replenishmentRequestDAL.CreateRequest(replenishmentRequest);
        }
    }
}
