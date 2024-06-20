using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms.ProductSubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ProductsForm(MainForm mainForm )
        {
            InitializeComponent();
            productService = new ProductService(new ProductDAL());
            brandService = new BrandService(new BrandDAL());
            categoryService = new CategoryService(new CategoryDAL());
            subCategoryService = new SubCategoryService(new SubCategoryDAL());
            addProductForm = new AddProductForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.mainForm = mainForm;

            cbBrand.Items.AddRange(brandService.GetAll().ToArray());
            cbCategory.Items.AddRange(categoryService.GetAll().ToArray());
            
            
            // Check if the logged-in user is a worker in the depot department
            var loggedInUser = mainForm.loggedInUser;
            
            MessageBox.Show(loggedInUser.Position);

            if (loggedInUser != null &&
                loggedInUser.Position.ToLower().Trim() == "worker" &&
                loggedInUser.Department.Name.ToLower().Trim() == "depot")
            {
                btnEdit.Visible = false; // Hide the Edit button
                btnAdd.Visible = false; // Hide the Add button
                btnDelete.Visible = false; // Hide the Delete button
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

            dgvProducts.DataSource = productService.GetAll();
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
    }
}
