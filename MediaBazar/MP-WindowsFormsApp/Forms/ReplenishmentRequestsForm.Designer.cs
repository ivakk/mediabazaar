namespace MP_WindowsFormsApp.Forms
{
    partial class ReplenishmentRequestsForm
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
            label1 = new Label();
            flpMain = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 54);
            label1.TabIndex = 0;
            label1.Text = "Replenishment Requests";
            // 
            // flpMain
            // 
            flpMain.Location = new Point(12, 66);
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(1410, 883);
            flpMain.TabIndex = 1;
            // 
            // ReplenishmentRequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 961);
            Controls.Add(flpMain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReplenishmentRequestsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReplenishmentRequestsForm";
            Load += ReplenishmentRequestsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpMain;
    }
}