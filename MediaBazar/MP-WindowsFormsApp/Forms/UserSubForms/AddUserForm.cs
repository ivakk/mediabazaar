using MP_BusinessLogic.Services;
using MP_DataAccess;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms.UserSubForms
{
    public partial class AddUserForm : Form
    {
        UserService userService = new UserService();
        PasswordHashing hashing = new PasswordHashing();

        //In case it is in edit mode
        User? User { get; set; }

        UsersForm usersForm;

        DepartmentService departmentService = new DepartmentService();
        public AddUserForm(UsersForm usersForm)
        {
            InitializeComponent();
            this.usersForm = usersForm;
        }

        public AddUserForm(UsersForm usersForm, User user)
        {
            InitializeComponent();
            this.usersForm = usersForm;
            this.User = user;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

            List<Department> departmentList = departmentService.GetAllDepartments();
            foreach (Department department in departmentList)
            {
                cbDepartment.Items.Add(department);
            }

            if(User != null)
            {
                tbFirstName.Text = User.FirstName;
                tbLastName.Text = User.LastName;
                tbEmail.Text = User.Email;
                tbPhoneNumber.Text = User.PhoneNumber;
                cbDepartment.SelectedIndex = cbDepartment.FindStringExact(User.Department.Name);
                cbPosition.Text = User.Position;
                dtpbirthday.Value = User.Birthdate;
                cbSalaryLevel.SelectedIndex = User.SalaryLevel;
                dtpContractStart.Value = User.StartContract;
                dtpContractEnd.Value = User.EndContract;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(User == null)
            {
                string passwordSalt = hashing.GenerateRandomSalt(10);
                string passwordHash = hashing.GenerateSHA256Hash("MediaBazar", passwordSalt);

                User user = new User(0,
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbEmail.Text,
                    tbPhoneNumber.Text,
                    cbPosition.Text,
                    dtpbirthday.Value,
                    passwordHash,
                    passwordSalt,
                    (Department)cbDepartment.SelectedItem,
                    dtpContractStart.Value,
                    dtpContractEnd.Value,
                    cbSalaryLevel.SelectedIndex);

                bool success = userService.CreateUser(user);
                if (success)
                {
                    usersForm.mainForm.ChangeShownForm(usersForm);
                }
            }
            else
            {
                User user = new User(User.Id,
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbEmail.Text,
                    tbPhoneNumber.Text,
                    cbPosition.Text,
                    dtpbirthday.Value,
                    User.PasswordHash,
                    User.PasswordSalt,
                    (Department)cbDepartment.SelectedItem,
                    dtpContractStart.Value,
                    dtpContractEnd.Value,
                    cbSalaryLevel.SelectedIndex);

                bool success = userService.UpdateUser(user);
                if (success)
                {
                    usersForm.mainForm.ChangeShownForm(usersForm);
                }
            }
            usersForm.LoadUsers(userService.GetAllUsers());
        }
    }
}
