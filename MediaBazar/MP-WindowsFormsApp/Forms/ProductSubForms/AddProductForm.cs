using MP_BusinessLogic.Services;
using MP_EntityLibrary;

namespace MP_WindowsFormsApp.Forms.ProductSubForms
{
    public partial class AddProductForm : Form
    {
        ProductService productService = new ProductService();
        BrandService brandService = new BrandService();
        CategoryService categoryService = new CategoryService();
        SubCategoryService subCategoryService = new SubCategoryService();
        ProductsForm productsForm;

        private int productId = 0;
        public AddProductForm(ProductsForm productsForm)
        {
            InitializeComponent();

            cbBrand.Items.AddRange(brandService.GetAll().ToArray());
            cbCategory.Items.AddRange(categoryService.GetAll().ToArray());
            this.productsForm = productsForm;
        }

        public void SetProductId(int productId = 0)
        {
            this.productId = productId;
            Product product = productService.GetById(productId);
            cbBrand.Text = product.Brand.Name;
            tbModel.Text = product.Model;
            cbCategory.Text = product.Category.Name;
            cbSubCategory.Text = product.SubCategory.Name;
            tbDescription.Text = product.Desciption;
            nudPrice.Value = product.Price;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = categoryService.GetByName(cbCategory.Text);
            SubCategory subCategory = subCategoryService.GetByName(cbSubCategory.Text);
            Brand brand = brandService.GetByName(cbBrand.Text);
            Product product = new Product(productId, category, subCategory, brand, tbModel.Text, tbDescription.Text, nudPrice.Value, 100);
            if (product.Id == 0)
                productService.Create(product);
            else
                productService.Update(product);
            this.Hide();
            productsForm.mainForm.ChangeShownForm(productsForm);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = cbCategory.SelectedItem as Category;
            SubCategory[] subCategories = subCategoryService.GetForCategory(category).ToArray();
            cbSubCategory.Items.AddRange(subCategories);
            cbSubCategory.Visible = true;
            lbSubCategory.Visible = true;
        }
    }
}
