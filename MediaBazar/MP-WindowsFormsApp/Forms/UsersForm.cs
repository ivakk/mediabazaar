using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms.ProductSubForms;
using MP_WindowsFormsApp.Forms.UserSubForms;
using MP_WindowsFormsApp.UserControls;
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
    public partial class UsersForm : Form
    {
        private readonly IUserService userService;
        private readonly IDepartmentService departmentService;
        public MainForm mainForm;
        private User loggedInUser; // Add this property
        AddUserForm addUserForm;

        public UsersForm(MainForm mainForm, IUserService userService, IDepartmentService departmentService, User loggedInUser)
        {
            InitializeComponent();
            this.userService = userService;
            this.departmentService = departmentService;
            this.mainForm = mainForm;
            this.loggedInUser = loggedInUser; // Initialize the logged-in user

            addUserForm = new AddUserForm(this, loggedInUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mainForm.pnlMainForm.Controls.Clear();
            this.mainForm.pnlMainForm.Controls.Add(addUserForm);
            addUserForm.Show();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            foreach (Department dep in departmentService.GetAllDepartments())
            {
                cbDepartment.Items.Add(dep);
            }

            LoadUsers(userService.GetAllUsers());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchFirstName = tbSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchFirstName))
            {
                UserDAL userDAL = new UserDAL(departmentService);
                User foundUser = userDAL.GetUserByUserName(searchFirstName);

                if (foundUser != null)
                {
                    LoadUsers(new List<User> { foundUser });
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            else
            {
                LoadUsers(userService.GetAllUsers());
            }
        }

        public void LoadUsers(List<User> users)
        {
            flpUsers.Controls.Clear();
            foreach (User user in users)
            {
                UsersUC userControl = new UsersUC(user, this);
                flpUsers.Controls.Add(userControl);
                userControl.Show();
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department dep = (Department)cbDepartment.SelectedItem;
            LoadUsers(userService.GetUsersByDepartment(dep.Id));
        }
    }
}
