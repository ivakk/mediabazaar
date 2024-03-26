using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.UserControls
{
    public partial class MenuButton : UserControl
    {
        public string ButtonText;
        public Form AssosiatedForm;
        private MainForm layoutFormRef;

        public MenuButton(string buttonText, Form assosiatedForm, MainForm layoutFormRef)
        {
            InitializeComponent();
            ButtonText = buttonText;
            AssosiatedForm = assosiatedForm;
            this.layoutFormRef = layoutFormRef;
            Button.Text = buttonText;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            layoutFormRef.pnlMainForm.Controls.Clear();
            this.layoutFormRef.pnlMainForm.Controls.Add(AssosiatedForm);
            AssosiatedForm.Show();
        }
    }
}
