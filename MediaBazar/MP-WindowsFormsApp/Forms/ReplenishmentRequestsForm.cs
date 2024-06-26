using MP_BusinessLogic.InterfacesLL;
using MP_WindowsFormsApp.UserControls;
using MP_EntityLibrary;
using System;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class ReplenishmentRequestsForm : Form
    {
        private readonly IProductService productService;
        private readonly User loggedInUser;
        private readonly IReplenishmentRequestService replenishmentRequestService;

        public ReplenishmentRequestsForm(IProductService productService, User loggedInUser, IReplenishmentRequestService replenishmentRequestService)
        {
            InitializeComponent();
            this.productService = productService;
            this.loggedInUser = loggedInUser;
            this.replenishmentRequestService = replenishmentRequestService;
        }

        private void ReplenishmentRequestsForm_Load(object sender, EventArgs e)
        {
            var requests = replenishmentRequestService.GetAllRequests();
            foreach (var request in requests)
            {
                var product = productService.GetById(request.ProductId);
                ReplenishmentRequestUC replenishmentRequestUC = new ReplenishmentRequestUC(product, loggedInUser, replenishmentRequestService, productService, request);
                flpMain.Controls.Add(replenishmentRequestUC);
                replenishmentRequestUC.Show();
            }
        }
    }
}
