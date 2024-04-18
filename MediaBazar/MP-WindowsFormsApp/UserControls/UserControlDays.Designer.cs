namespace MP_WindowsFormsApp.UserControls
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDay = new Label();
            lblEvent = new Label();
            lblEmployeeName = new Label();
            lblShiftTime = new Label();
            SuspendLayout();
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDay.Location = new Point(14, 18);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(34, 25);
            lblDay.TabIndex = 0;
            lblDay.Text = "00";
            // 
            // lblEvent
            // 
            lblEvent.Location = new Point(3, 99);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(181, 82);
            lblEvent.TabIndex = 1;
            lblEvent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(23, 67);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(0, 20);
            lblEmployeeName.TabIndex = 2;
            // 
            // lblShiftTime
            // 
            lblShiftTime.AutoSize = true;
            lblShiftTime.Location = new Point(14, 87);
            lblShiftTime.Name = "lblShiftTime";
            lblShiftTime.Size = new Size(0, 20);
            lblShiftTime.TabIndex = 3;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblShiftTime);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblEvent);
            Controls.Add(lblDay);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlDays";
            Size = new Size(187, 181);
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblEvent;
        private Label lblEmployeeName;
        private Label lblShiftTime;
    }
}
