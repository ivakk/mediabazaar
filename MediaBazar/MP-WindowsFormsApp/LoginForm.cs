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
            this.Hide();
            if (tbEmail.Text == "1" && tbPassword.Text == "1")
            {
                MainForm layoutForm = new MainForm(this);
                layoutForm.ShowDialog();
            } 
        }
    }
}