using MP_BusinessLogic.Services;
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
        UserService userService = new UserService();
        DepartmentService departmentService = new DepartmentService();

        public MainForm mainForm;
        AddUserForm addUserForm;
        public UsersForm(MainForm mainForm)
        {
            InitializeComponent();
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
            LoadUsers(userService.GetBySearch(tbSearch.Text));
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
