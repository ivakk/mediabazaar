using MP_BusinessLogic.Services;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms;
using MP_WindowsFormsApp.Forms.UserSubForms;
using MP_BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP_BusinessLogic.InterfacesLL;
using MP_DataAccess.DALManagers;

namespace MP_WindowsFormsApp.UserControls
{
    public partial class UsersUC : UserControl
    {
        private readonly IUserService userService;
        private readonly IDepartmentService departmentService;
        
        //UserService userService = new UserService();
        UsersForm usersForm;
        public User User { get; set; }
        public UsersUC(User user, UsersForm usersForm)
        {
            InitializeComponent();
            departmentService = new DepartmentService(new DepartmentDAL());
            this.userService = new UserService(new UserDAL(departmentService));
            this.User = user;
            this.usersForm = usersForm;
        }

        private void UsersUC_Load(object sender, EventArgs e)
        {
            lbDepartment.Text = User.Department.Name;
            lbEmail.Text = User.Email;
            lbFirstName.Text = User.FirstName;
            lbLastName.Text = User.LastName;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(usersForm, User) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None }; ;
            usersForm.mainForm.ChangeShownForm(addUserForm);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(User != null)
            {
                userService.DeleteUser(User.Id);
                usersForm.LoadUsers(userService.GetAllUsers());
                usersForm.mainForm.ChangeShownForm(usersForm);
            }   
        }
    }
}
