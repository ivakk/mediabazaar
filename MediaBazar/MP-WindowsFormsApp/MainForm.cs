using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms;
using MP_WindowsFormsApp.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MP_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected readonly IUserService userService;
        private readonly IProductService productService;
        private readonly IBrandService brandService;
        private readonly ICategoryService categoryService;
        private readonly IDepartmentService departmentService;
        private readonly IReplenishmentRequestService replenishmentRequestService;

        LoginForm loginForm;
        public User loggedInUser;
        public List<MenuButton> menuButtons = new List<MenuButton>();

        private ProductsForm productForm;
        private UsersForm userForm;
        private ScheduleForm scheduleForm;
        private DepartmentForm departmentForm;
        private ReplenishmentRequestsForm replenishmentRequestsForm;
        public ShiftManagement shiftManagementForm;

        public Dictionary<string, object> accessForms;

        public MainForm(User user, LoginForm loginForm)
        {
            InitializeComponent();
            departmentService = new DepartmentService(new DepartmentDAL());
            userService = new UserService(new UserDAL(departmentService));
            productService = new ProductService(new ProductDAL());
            brandService = new BrandService(new BrandDAL());
            categoryService = new CategoryService(new CategoryDAL());
            replenishmentRequestService = new ReplenishmentRequestService(new ReplenishmentRequestDAL());

            this.loginForm = loginForm;
            this.loggedInUser = user;

            productForm = new ProductsForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            userForm = new UsersForm(this, userService, departmentService, loggedInUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            scheduleForm = new ScheduleForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            departmentForm = new DepartmentForm(departmentService, loggedInUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            replenishmentRequestsForm = new ReplenishmentRequestsForm(productService, loggedInUser, replenishmentRequestService) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            shiftManagementForm = new ShiftManagement(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };

            if (!(loggedInUser.Position.ToLower().Trim() == "worker" && loggedInUser.Department.Name.ToLower().Trim() == "depot" || loggedInUser.Department.Name.ToLower().Trim() == "sales"))
            {
                menuButtons.Add(new MenuButton("Employees", userForm, this));
            }

            menuButtons.Add(new MenuButton("Products", productForm, this));
            menuButtons.Add(new MenuButton("Replenishment", replenishmentRequestsForm, this));
            menuButtons.Add(new MenuButton("Scheduling", shiftManagementForm, this));
            menuButtons.Add(new MenuButton("Departments", departmentForm, this));

            LoadMenuButtons();

            accessForms = new Dictionary<string, object>()
            {
                { "Products", productForm },
                { "Employees", userForm },
                { "Scheduling", shiftManagementForm },
                { "Departments", departmentForm }
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        public void LoadMenuButtons()
        {
            flpMenu.Controls.Clear();
            loggedInUser = userService.GetUserById(loggedInUser.Id);

            foreach (MenuButton button in menuButtons)
            {
                if (button.Text != "Employees" || !(loggedInUser.Position == "worker" && loggedInUser.Department.Name == "depot"))
                {
                    flpMenu.Controls.Add(button);
                }
            }
        }

        public void ChangeShownForm(Form form)
        {
            pnlMainForm.Controls.Clear();
            pnlMainForm.Controls.Add(form);
            form.Show();
        }
    }
}
