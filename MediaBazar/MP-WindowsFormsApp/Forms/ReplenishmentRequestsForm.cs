using MP_BusinessLogic.InterfacesLL;
using MP_WindowsFormsApp.UserControls;
using System;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class ReplenishmentRequestsForm : Form
    {
        private readonly IProductService productService;
        private readonly IReplenishmentRequestService replenishmentRequestService;

        public ReplenishmentRequestsForm(IProductService productService, IReplenishmentRequestService replenishmentRequestService)
        {
            InitializeComponent();
            this.productService = productService;
            this.replenishmentRequestService = replenishmentRequestService;
        }

        private void ReplenishmentRequestsForm_Load(object sender, EventArgs e)
        {
            var requests = replenishmentRequestService.GetAllRequests();
            foreach (var request in requests)
            {
                var product = productService.GetById(request.ProductId);
                ReplenishmentRequestUC replenishmentRequestUC = new ReplenishmentRequestUC(product, request);
                flpMain.Controls.Add(replenishmentRequestUC);
                replenishmentRequestUC.Show();
            }
        }
    }
}
