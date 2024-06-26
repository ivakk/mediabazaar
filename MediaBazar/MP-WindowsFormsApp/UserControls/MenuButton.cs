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
        private MainForm mainFormRef;

        public MenuButton(string buttonText, Form assosiatedForm, MainForm mainFormRef)
        {
            InitializeComponent();
            ButtonText = buttonText;
            AssosiatedForm = assosiatedForm;
            this.mainFormRef = mainFormRef;
            Button.Text = buttonText;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            mainFormRef.pnlMainForm.Controls.Clear();
            this.mainFormRef.pnlMainForm.Controls.Add(AssosiatedForm);
            AssosiatedForm.Show();
        }
    }
}
