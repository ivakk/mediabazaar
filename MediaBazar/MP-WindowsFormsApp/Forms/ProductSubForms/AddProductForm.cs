using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;

namespace MP_WindowsFormsApp.Forms.ProductSubForms
{
    public partial class AddProductForm : Form
    {
        private readonly IProductService productService;
        private readonly IBrandService brandService;
        private readonly ICategoryService categoryService;
        private readonly ISubCategoryService subCategoryService;

        //public AddProductForm(IProductService productService, IBrandService brandService, ICategoryService categoryService, ISubCategoryService subCategoryService)
        //{
        //    InitializeComponent();
        //    this.productService = productService;
        //    this.brandService = brandService;
        //    this.categoryService = categoryService;
        //    this.subCategoryService = subCategoryService;
        //}
        //ProductService productService = new ProductService();
        //BrandService brandService = new BrandService();
        //CategoryService categoryService = new CategoryService();
        //SubCategoryService subCategoryService = new SubCategoryService();
        ProductsForm productsForm;

        private int productId = 0;
        public AddProductForm(ProductsForm productsForm )
        {
            InitializeComponent();
            productService = new ProductService(new ProductDAL());
            brandService = new BrandService(new BrandDAL());
            categoryService = new CategoryService(new CategoryDAL());
            subCategoryService = new SubCategoryService(new SubCategoryDAL());
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
            tbUPCcode.Text = product.UPCcode;
            nudWeight.Value = product.Weight;
            nudHeight.Value = product.Height;
            nudWidth.Value = product.Width;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = categoryService.GetByName(cbCategory.Text);
            SubCategory subCategory = subCategoryService.GetByName(cbSubCategory.Text);
            Brand brand = brandService.GetByName(cbBrand.Text);
            Product product = new Product(productId, category, subCategory, brand, tbModel.Text, tbDescription.Text, nudPrice.Value, 100, tbUPCcode.Text, 17, nudWeight.Value, nudHeight.Value, nudWidth.Value);
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
