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
    public partial class ReplenishmentRequestsForm : Form
    {
        public ReplenishmentRequestsForm()
        {
            InitializeComponent();
        }

        private void ReplenishmentRequestsForm_Load(object sender, EventArgs e)
        {
            ReplenishmentRequestUC replenishmentRequestUC = new ReplenishmentRequestUC();
            flpMain.Controls.Add(replenishmentRequestUC);
            replenishmentRequestUC.Show();
        }
    }
}
