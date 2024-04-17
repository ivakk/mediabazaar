namespace MP_WindowsFormsApp.Forms
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dayContainer = new FlowLayoutPanel();
            btnNext = new Button();
            btnPrevious = new Button();
            lblSunday = new Label();
            lblMonday = new Label();
            lblWednesday = new Label();
            lblTuesday = new Label();
            lblFriday = new Label();
            lblThursday = new Label();
            lblSaturday = new Label();
            lblDate = new Label();
            SuspendLayout();
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(81, 106);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1288, 746);
            dayContainer.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1261, 874);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(128, 40);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(1102, 874);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(128, 40);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblSunday
            // 
            lblSunday.AutoSize = true;
            lblSunday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSunday.Location = new Point(163, 63);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(82, 23);
            lblSunday.TabIndex = 3;
            lblSunday.Text = "Sunday";
            // 
            // lblMonday
            // 
            lblMonday.AutoSize = true;
            lblMonday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonday.Location = new Point(333, 63);
            lblMonday.Name = "lblMonday";
            lblMonday.Size = new Size(87, 23);
            lblMonday.TabIndex = 4;
            lblMonday.Text = "Monday";
            // 
            // lblWednesday
            // 
            lblWednesday.AutoSize = true;
            lblWednesday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWednesday.Location = new Point(677, 63);
            lblWednesday.Name = "lblWednesday";
            lblWednesday.Size = new Size(122, 23);
            lblWednesday.TabIndex = 6;
            lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            lblTuesday.AutoSize = true;
            lblTuesday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTuesday.Location = new Point(504, 63);
            lblTuesday.Name = "lblTuesday";
            lblTuesday.Size = new Size(92, 23);
            lblTuesday.TabIndex = 5;
            lblTuesday.Text = "Tuesday";
            // 
            // lblFriday
            // 
            lblFriday.AutoSize = true;
            lblFriday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFriday.Location = new Point(1070, 63);
            lblFriday.Name = "lblFriday";
            lblFriday.Size = new Size(70, 23);
            lblFriday.TabIndex = 8;
            lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            lblThursday.AutoSize = true;
            lblThursday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThursday.Location = new Point(872, 63);
            lblThursday.Name = "lblThursday";
            lblThursday.Size = new Size(101, 23);
            lblThursday.TabIndex = 7;
            lblThursday.Text = "Thursday";
            // 
            // lblSaturday
            // 
            lblSaturday.AutoSize = true;
            lblSaturday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaturday.Location = new Point(1239, 63);
            lblSaturday.Name = "lblSaturday";
            lblSaturday.Size = new Size(96, 23);
            lblSaturday.TabIndex = 9;
            lblSaturday.Text = "Saturday";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(486, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(441, 43);
            lblDate.TabIndex = 10;
            lblDate.Text = "MONTH YEAR";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1383, 918);
            Controls.Add(lblDate);
            Controls.Add(lblSaturday);
            Controls.Add(lblFriday);
            Controls.Add(lblThursday);
            Controls.Add(lblWednesday);
            Controls.Add(lblTuesday);
            Controls.Add(lblMonday);
            Controls.Add(lblSunday);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(dayContainer);
            Margin = new Padding(4);
            Name = "ScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule";
            Load += Schedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel dayContainer;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblSunday;
        private Label lblMonday;
        private Label lblWednesday;
        private Label lblTuesday;
        private Label lblFriday;
        private Label lblThursday;
        private Label lblSaturday;
        private Label lblDate;
    }
}