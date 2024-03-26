using MP_WindowsFormsApp.Forms;
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

namespace MP_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        LoginForm loginForm;
        List<MenuButton> menuButtons = new List<MenuButton>();

        //Loading forms for buttons
        private ProductsForm productForm;
        private UsersForm userForm = new UsersForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        private ReplenishmentRequestsForm replenishmentRequestsForm = new ReplenishmentRequestsForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            productForm = new ProductsForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.loginForm = loginForm;

            //Loading buttons
            menuButtons.Add(new MenuButton("Products", productForm, this));
            menuButtons.Add(new MenuButton("Replenishment", replenishmentRequestsForm, this));
            menuButtons.Add(new MenuButton("Users", userForm, this));

            foreach (MenuButton button in menuButtons)
            {
                flpMenu.Controls.Add(button);
            }
        }

        private void LayoutForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
        public void ChangeShownForm(Form form)
        {
            pnlMainForm.Controls.Clear();
            pnlMainForm.Controls.Add(form);
            form.Show();
        }
    }
}
