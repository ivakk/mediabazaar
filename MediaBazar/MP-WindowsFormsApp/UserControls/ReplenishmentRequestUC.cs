using MP_EntityLibrary;
using MP_BusinessLogic.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.UserControls
{
    public partial class ReplenishmentRequestUC : UserControl
    {
        private readonly Product product;
        private readonly ReplenishmentRequest replenishmentRequest;

        public ReplenishmentRequestUC(Product product, ReplenishmentRequest replenishmentRequest)
        {
            InitializeComponent();
            this.product = product;
            this.replenishmentRequest = replenishmentRequest;
            InitializeProductDetails();
        }

        private void InitializeProductDetails()
        {
            label1.Text = product.Brand.Name;
            label2.Text = product.Model;
            label3.Text = "Category: " + product.Category.Name;
            label4.Text = "Sub-Category: " + product.SubCategory.Name;
            label5.Text = "Price: $" + product.Price.ToString("F2");
            label7.Text = "Amount: " + replenishmentRequest.RequestedQuantity;
            btnStatus.Text = replenishmentRequest.Status;
            btnStatus.BackColor = GetStatusColor(replenishmentRequest.Status);
        }

        private Color GetStatusColor(string status)
        {
            switch (status.ToUpper())
            {
                case "OPEN":
                    return Color.Red;
                case "CLOSED":
                    return Color.Green;
                case "DECLINED":
                    return Color.DarkRed;
                default:
                    return Color.Gray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (btnStatus.Text)
            {
                case "OPEN":
                    btnStatus.Text = "CLOSED";
                    btnStatus.BackColor = Color.Green;
                    break;
                case "CLOSED":
                    btnStatus.Text = "DECLINED";
                    btnStatus.BackColor = Color.DarkRed;
                    break;
                case "DECLINED":
                    btnStatus.Text = "OPEN";
                    btnStatus.BackColor = Color.Red;
                    break;
            }
            // Update the status in the database if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ReplenishmentRequestUC_Load(object sender, EventArgs e)
        {
        }
    }
}
