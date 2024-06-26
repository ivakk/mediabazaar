using MP_BusinessLogic.Entities;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms.ProductSubForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class ProductsForm : Form
    {
        public MainForm mainForm;
        AddProductForm addProductForm;

        private readonly IProductService productService;
        private readonly IBrandService brandService;
        private readonly ICategoryService categoryService;
        private readonly ISubCategoryService subCategoryService;
        private readonly IReplenishmentRequestService replenishmentRequestService;

        public ProductsForm(MainForm mainForm)
        {
            InitializeComponent();
            productService = new ProductService(new ProductDAL());
            brandService = new BrandService(new BrandDAL());
            categoryService = new CategoryService(new CategoryDAL());
            subCategoryService = new SubCategoryService(new SubCategoryDAL());
            replenishmentRequestService = new ReplenishmentRequestService(new ReplenishmentRequestDAL());
            addProductForm = new AddProductForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.mainForm = mainForm;

            cbBrand.Items.AddRange(brandService.GetAll().ToArray());
            cbCategory.Items.AddRange(categoryService.GetAll().ToArray());

            // Check if the logged-in user is a worker in the depot department
            var loggedInUser = mainForm.loggedInUser;

            if (loggedInUser != null &&
                loggedInUser.Position.ToLower().Trim() == "worker" &&
                (loggedInUser.Department.Name.ToLower().Trim() == "depot" || loggedInUser.Department.Name.ToLower().Trim() == "sales"))
            {
                btnEdit.Visible = false; // Hide the Edit button
                btnAdd.Visible = false; // Hide the Add button
                btnDelete.Visible = false; // Hide the Delete button
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productService.GetAll();
            CheckProductStock();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = cbCategory.SelectedItem as Category;
            cbSubCategory.Items.Add(subCategoryService.GetForCategory(category).ToArray());
            cbSubCategory.Visible = true;
            lbSubCategory.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productService.GetBySearch(tbSearch.Text + cbBrand.Text + cbCategory.Text + cbSubCategory.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product product = (Product)dgvProducts.CurrentRow.DataBoundItem;
            addProductForm.SetProductId(product.Id);
            mainForm.pnlMainForm.Controls.Clear();
            this.mainForm.pnlMainForm.Controls.Add(addProductForm);
            addProductForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = (Product)dgvProducts.CurrentRow.DataBoundItem;
            productService.Delete(product.Id);
            dgvProducts.DataSource = productService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mainForm.pnlMainForm.Controls.Clear();
            this.mainForm.pnlMainForm.Controls.Add(addProductForm);
            addProductForm.Show();
        }

        private void CheckProductStock()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.StoreQuantity < 17) // Assuming threshold is 5
                {
                    var existingRequests = replenishmentRequestService.GetRequestsByProductId(product.Id);
                    if (existingRequests.Count == 0)
                    {
                        CreateReplenishmentRequest(product);
                        MessageBox.Show($"Product {product.Brand.Name}: {product.Model} is below the threshold and a replenishment request has been created.");
                    }
                }
            }
        }

        private void CreateReplenishmentRequest(Product product)
        {
            ReplenishmentRequest replenishmentRequest = new ReplenishmentRequest
            {
                ProductId = product.Id,
                RequestedQuantity = 10, // Example quantity to restock
                Status = "OPEN",
                RequestDate = DateTime.Now
            };

            replenishmentRequestService.CreateRequest(replenishmentRequest);
        }
    }
}
