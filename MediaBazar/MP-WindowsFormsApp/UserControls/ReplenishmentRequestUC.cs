using MP_BusinessLogic.Entities;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.UserControls
{
    public partial class ReplenishmentRequestUC : UserControl
    {
        private readonly Product product;
        private readonly User loggedInUser;
        private readonly IReplenishmentRequestService replenishmentRequestService;
        private readonly IProductService productService;
        private readonly ReplenishmentRequest replenishmentRequest;

        public ReplenishmentRequestUC(Product product, User loggedInUser, IReplenishmentRequestService replenishmentRequestService, IProductService productService, ReplenishmentRequest replenishmentRequest)
        {
            InitializeComponent();
            this.product = product;
            this.loggedInUser = loggedInUser;
            this.replenishmentRequestService = replenishmentRequestService;
            this.productService = productService;
            this.replenishmentRequest = replenishmentRequest;
            InitializeProductDetails();
            SetModifyPermissions();
        }

        private void InitializeProductDetails()
        {
            label1.Text = product.Brand.Name;
            label2.Text = product.Model;
            label3.Text = "Category: " + product.Category.Name;
            label4.Text = "Sub-Category: " + product.SubCategory.Name;
            label5.Text = "Price: $" + product.Price.ToString("F2");
            label7.Text = "Amount: " + replenishmentRequest.RequestedQuantity;
            label6.Text = "Status: " + replenishmentRequest.Status;
            SetButtonVisibility();
        }

        private void SetModifyPermissions()
        {
            if (loggedInUser.Department.Id == 1 || (loggedInUser.Position.ToLower() == "manager" && loggedInUser.Department.Name.ToLower() == "depot"))
            {
                btnApprove.Enabled = true;
                btnReject.Enabled = true;
            }
            else
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
            }
        }

        private void SetButtonVisibility()
        {
            btnApprove.Visible = replenishmentRequest.Status == "OPEN";
            btnReject.Visible = replenishmentRequest.Status == "OPEN";
            btnRemove.Visible = replenishmentRequest.Status == "CLOSED" || replenishmentRequest.Status == "DECLINED";
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (product.WarehouseQuantity < replenishmentRequest.RequestedQuantity)
            {
                MessageBox.Show("Not enough quantity in the warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            replenishmentRequest.Status = "CLOSED";
            replenishmentRequest.ApprovedDate = DateTime.Now;
            replenishmentRequest.ApprovedBy = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
            replenishmentRequestService.UpdateRequest(replenishmentRequest);

            product.WarehouseQuantity -= replenishmentRequest.RequestedQuantity;
            product.StoreQuantity += replenishmentRequest.RequestedQuantity;
            productService.Update(product);

            label6.Text = "Status: " + replenishmentRequest.Status;
            SetButtonVisibility();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            replenishmentRequest.Status = "DECLINED";
            replenishmentRequest.ApprovedDate = DateTime.Now;
            replenishmentRequest.ApprovedBy = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
            replenishmentRequestService.UpdateRequest(replenishmentRequest);
            label6.Text = "Status: " + replenishmentRequest.Status;
            SetButtonVisibility();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ReplenishmentRequestUC_Load(object sender, EventArgs e)
        {
        }
    }
}
