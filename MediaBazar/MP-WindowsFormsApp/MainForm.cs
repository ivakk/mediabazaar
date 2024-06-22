using MP_BusinessLogic.Services;
using MP_WindowsFormsApp.Forms;
using MP_WindowsFormsApp.UserControls;
using MP_WindowsFormsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP_EntityLibrary;
using MP_BusinessLogic.InterfacesLL;
using MP_DataAccess.DALManagers;

namespace MP_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        protected readonly IUserService userService;
        private readonly IProductService productService;
        private readonly IBrandService brandService;
        private readonly ICategoryService categoryService;
        private readonly IDepartmentService departmentService;

        LoginForm loginForm;
        public User loggedInUser;
        protected List<MenuButton> menuButtons = new List<MenuButton>();

        // Loading forms for buttons
        private ProductsForm productForm;
        private UsersForm userForm;
        private ScheduleForm scheduleForm;
        private DepartmentForm departmentForm;
        private ReplenishmentRequestsForm replenishmentRequestsForm = new ReplenishmentRequestsForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };

        public Dictionary<string, object> accessForms;

        public MainForm(User user, LoginForm loginForm)
        {
            InitializeComponent();
            departmentService = new DepartmentService(new DepartmentDAL());
            userService = new UserService(new UserDAL(departmentService));
            productService = new ProductService(new ProductDAL());
            brandService = new BrandService(new BrandDAL());
            categoryService = new CategoryService(new CategoryDAL());

            this.loginForm = loginForm;
            this.loggedInUser = user;

            // Loading buttons
            productForm = new ProductsForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            userForm = new UsersForm(this, userService, departmentService, loggedInUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            scheduleForm = new ScheduleForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            departmentForm = new DepartmentForm(departmentService, loggedInUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };

            // Check if the logged-in user is not a worker in the depot department before adding the Users button
            if (!(loggedInUser.Position.ToLower().Trim() == "worker" && loggedInUser.Department.Name.ToLower().Trim() == "depot" || loggedInUser.Department.Name.ToLower().Trim() == "sales"))
            {
                menuButtons.Add(new MenuButton("Users", userForm, this));
            }

            menuButtons.Add(new MenuButton("Products", productForm, this));
            menuButtons.Add(new MenuButton("Replenishment", replenishmentRequestsForm, this));
            menuButtons.Add(new MenuButton("Scheduling", scheduleForm, this));
            menuButtons.Add(new MenuButton("Departments", departmentForm, this));



            LoadMenuButtons();

            // Setting up form access
            accessForms = new Dictionary<string, object>()
            {
                { "Products", productForm },
                { "Users", userForm },
                { "Scheduling", scheduleForm },
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

            MessageBox.Show("User position is " + loggedInUser.Position.ToString() + loggedInUser.Department.ToString() );

            foreach (MenuButton button in menuButtons)
            {
                // Add the button to the flow layout panel if it passes the access check
                if (button.Text != "Users" || !(loggedInUser.Position == "worker" && loggedInUser.Department.Name == "depot"))
                {
                    flpMenu.Controls.Add(button);
                }
                // foreach (KeyValuePair<string, object> entry in accessForms)
                // {
                //     if (loggedInUser.Department.AccessString.Contains(entry.Key) || loggedInUser == null)
                //     {
                //         menuButtons.Add(new MenuButton(entry.Key, (Form)entry.Value, this));
                //         flpMenu.Controls.Add(menuButtons[menuButtons.Count - 1]);
                //     }
                // }
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
