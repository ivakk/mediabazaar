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
        //public UsersForm(IUserService userService, IDepartmentService departmentService)
        //{
        //    InitializeComponent();
        //    this.userService = userService;
        //    departmentService = new DepartmentService(new DepartmentDAL());

        //}
        //UserService userService = new UserService();
        //DepartmentService departmentService = new DepartmentService();

        public MainForm mainForm;
        AddUserForm addUserForm;
        public UsersForm(MainForm mainForm, IUserService userService, IDepartmentService departmentService)
        {
            InitializeComponent();
            this.userService = userService;
            this.departmentService = departmentService;
            //departmentService = new DepartmentService(new DepartmentDAL());
            this.mainForm = mainForm;

            addUserForm = new AddUserForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
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
            //change to name and last name later

            //FIX
    
            LoadUsers(userService.GetAllUsers());
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
