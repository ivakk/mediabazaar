namespace MP_WindowsFormsApp.UserControls
{
    public partial class ReplenishmentRequestUC : UserControl
    {
        public ReplenishmentRequestUC()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnStatus.Text == "OPEN")
            {
                btnStatus.Text = "CLOSED";
                btnStatus.BackColor = Color.Green;
            }
            else if (btnStatus.Text == "CLOSED")
            {
                btnStatus.Text = "DECLINED";
                btnStatus.BackColor = Color.DarkRed;
            }
            else if (btnStatus.Text == "DECLINED")
            {
                btnStatus.Text = "OPEN";
                btnStatus.BackColor = Color.DarkRed;
            }
        }

        private void ReplenishmentRequestUC_Load(object sender, EventArgs e)
        {

        }
    }
}
