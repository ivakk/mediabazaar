using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess;
using MP_DataAccess.DALManagers;
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
        private readonly IUserService userService;
        private readonly IDepartmentService departmentService;
        private User loggedInUser;
        //private readonly UserService userService;
        User user;
        //public AddUserForm(IUserService userService, IDepartmentService departmentService)
        //{
        //    this.userService = userService;
        //    this.departmentService = departmentService;
        //}
        //UserService userService = new UserService();
        PasswordHashing hashing = new PasswordHashing();

        //In case it is in edit mode
        User? User { get; set; }

        UsersForm usersForm;

        public AddUserForm(UsersForm usersForm, User loggedInUser)
        {
            InitializeComponent();
            this.departmentService = new DepartmentService(new DepartmentDAL());
            this.userService = new UserService(new UserDAL(departmentService));
            this.usersForm = usersForm;
            this.loggedInUser = loggedInUser; 
        }

        public AddUserForm(UsersForm usersForm, User user, User loggedInUser)
        {
            InitializeComponent();
            this.departmentService = new DepartmentService(new DepartmentDAL());
            this.userService = new UserService(new UserDAL(departmentService));
            this.usersForm = usersForm;
            this.user = user;
            this.loggedInUser = loggedInUser; 
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            string currentUserDepartment = loggedInUser.Department.Name;
            List<Department> departmentList = departmentService.GetAllDepartments();
            foreach (Department department in departmentList)
            {
                cbDepartment.Items.Add(department);
            }
            if (!(currentUserDepartment == "ADMIN" || currentUserDepartment == "HR"))
            {
                btnAdd.Visible = false;
            }
            if (User != null)
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
            if (!ValidateInputs())
            {
                MessageBox.Show("Please check your inputs and try again.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (User == null)
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

                bool success = userService.InsertUser(user);
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


        private bool ValidateInputs()
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Name fields must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Email
            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Phone
            if (!IsValidPhone(tbPhoneNumber.Text))
            {
                MessageBox.Show("Enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Department
            if (cbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Birthdate (Example: not in the future)
            if (dtpbirthday.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Birthdate must be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Contract Dates
            if (dtpContractStart.Value.Date > dtpContractEnd.Value.Date)
            {
                MessageBox.Show("Contract start date must be before the end date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\+[1-9]{1}[0-9]{3,14}$");
        }
    }
}
