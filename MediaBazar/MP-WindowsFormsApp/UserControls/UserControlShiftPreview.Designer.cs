namespace MP_WindowsFormsApp.UserControls
{
    partial class UserControlShiftPreview
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
            ShiftDemand = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ShiftDemand).BeginInit();
            SuspendLayout();
            // 
            // ShiftDemand
            // 
            ShiftDemand.Location = new Point(133, 6);
            ShiftDemand.Margin = new Padding(4, 3, 4, 3);
            ShiftDemand.Name = "ShiftDemand";
            ShiftDemand.Size = new Size(38, 23);
            ShiftDemand.TabIndex = 4;
            ShiftDemand.ValueChanged += ShiftDemand_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 173);
            button1.TabIndex = 3;
            button1.Text = "Empty";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserControlShiftPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ShiftDemand);
            Controls.Add(button1);
            Name = "UserControlShiftPreview";
            Size = new Size(175, 173);
            Load += UserControlShiftPreview_Load;
            ((System.ComponentModel.ISupportInitialize)ShiftDemand).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown ShiftDemand;
        private Button button1;
    }
}
