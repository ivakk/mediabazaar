using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
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
    public partial class ForgotPasswordForm : Form
    {
        private readonly IUserService userService;
        private readonly IDepartmentService departmentService;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            departmentService = new DepartmentService(new DepartmentDAL());
            userService = new UserService(new UserDAL(departmentService));
        }

        private void lbReturnToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(userService);
            loginForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string newPassword = tbNewPassword.Text;
            string confirmNewPassword = tbConfirmPassword.Text;

            if (email == "" || newPassword == "" || confirmNewPassword == "")
            {
                MessageBox.Show("Enter your email and the new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Make sure that the new password and the confirm password matches", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //check if there is user with that email
                    User user = userService.GetUserByEmail(email);
                    if (user != null)
                    {
                        
                        if (userService.ChangePassword(user.Email, newPassword))
                        {
                            
                            MessageBox.Show("Your password has been succesfully changed !");
                        }

                    }
                    else
                    {
                        MessageBox.Show("There is no user with that email !");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Your login details are incorrect!");
                }
            }
        }
    }
}
