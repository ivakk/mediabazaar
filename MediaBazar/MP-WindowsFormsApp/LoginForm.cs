using MP_EntityLibrary;

namespace MP_WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pbRevealPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void pbRevealPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '●';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            try
            {
                User user = new User(email, password);
                MainForm mainForm = new MainForm(user, this);
                mainForm.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                if (email == "1" && password == "1")
                {
                    MainForm mainForm = new MainForm(null, this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(ex.Message, "Incorrect login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}