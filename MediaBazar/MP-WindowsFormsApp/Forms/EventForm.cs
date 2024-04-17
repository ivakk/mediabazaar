using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP_WindowsFormsApp.UserControls;

namespace MP_WindowsFormsApp.Forms
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txbDate.Text = ScheduleForm.static_month + "/" + UserControlDays.static_day + "/" + ScheduleForm.static_year;
        }
    }
}
