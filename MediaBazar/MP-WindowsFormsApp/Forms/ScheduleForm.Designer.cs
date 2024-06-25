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
            button1 = new Button();
            SuspendLayout();
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(212, 60);
            dayContainer.Margin = new Padding(2);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1030, 859);
            dayContainer.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1334, 923);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 32);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(1228, 923);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(102, 32);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblSunday
            // 
            lblSunday.AutoSize = true;
            lblSunday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSunday.Location = new Point(279, 40);
            lblSunday.Margin = new Padding(2, 0, 2, 0);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(64, 18);
            lblSunday.TabIndex = 3;
            lblSunday.Text = "Sunday";
            // 
            // lblMonday
            // 
            lblMonday.AutoSize = true;
            lblMonday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonday.Location = new Point(415, 40);
            lblMonday.Margin = new Padding(2, 0, 2, 0);
            lblMonday.Name = "lblMonday";
            lblMonday.Size = new Size(69, 18);
            lblMonday.TabIndex = 4;
            lblMonday.Text = "Monday";
            // 
            // lblWednesday
            // 
            lblWednesday.AutoSize = true;
            lblWednesday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWednesday.Location = new Point(691, 40);
            lblWednesday.Margin = new Padding(2, 0, 2, 0);
            lblWednesday.Name = "lblWednesday";
            lblWednesday.Size = new Size(98, 18);
            lblWednesday.TabIndex = 6;
            lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            lblTuesday.AutoSize = true;
            lblTuesday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTuesday.Location = new Point(552, 40);
            lblTuesday.Margin = new Padding(2, 0, 2, 0);
            lblTuesday.Name = "lblTuesday";
            lblTuesday.Size = new Size(72, 18);
            lblTuesday.TabIndex = 5;
            lblTuesday.Text = "Tuesday";
            // 
            // lblFriday
            // 
            lblFriday.AutoSize = true;
            lblFriday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFriday.Location = new Point(1005, 40);
            lblFriday.Margin = new Padding(2, 0, 2, 0);
            lblFriday.Name = "lblFriday";
            lblFriday.Size = new Size(56, 18);
            lblFriday.TabIndex = 8;
            lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            lblThursday.AutoSize = true;
            lblThursday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThursday.Location = new Point(847, 40);
            lblThursday.Margin = new Padding(2, 0, 2, 0);
            lblThursday.Name = "lblThursday";
            lblThursday.Size = new Size(77, 18);
            lblThursday.TabIndex = 7;
            lblThursday.Text = "Thursday";
            // 
            // lblSaturday
            // 
            lblSaturday.AutoSize = true;
            lblSaturday.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaturday.Location = new Point(1140, 40);
            lblSaturday.Margin = new Padding(2, 0, 2, 0);
            lblSaturday.Name = "lblSaturday";
            lblSaturday.Size = new Size(74, 18);
            lblSaturday.TabIndex = 9;
            lblSaturday.Text = "Saturday";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(533, 0);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(353, 34);
            lblDate.TabIndex = 10;
            lblDate.Text = "MONTH YEAR";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(212, 923);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(102, 32);
            button1.TabIndex = 11;
            button1.Text = "Auto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1447, 966);
            Controls.Add(button1);
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
        private Button button1;
    }
}