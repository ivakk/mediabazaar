namespace MP_WindowsFormsApp.UserControls
{
	partial class UserControlShift
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
            this.button1 = new System.Windows.Forms.Button();
            this.ShiftDemand = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftDemand)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 1;
            this.button1.Text = "Empty";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShiftDemand
            // 
            this.ShiftDemand.Location = new System.Drawing.Point(114, 5);
            this.ShiftDemand.Name = "ShiftDemand";
            this.ShiftDemand.Size = new System.Drawing.Size(33, 20);
            this.ShiftDemand.TabIndex = 2;
            this.ShiftDemand.ValueChanged += new System.EventHandler(this.ShiftDemand_ValueChanged);
            // 
            // UserControlShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShiftDemand);
            this.Controls.Add(this.button1);
            this.Name = "UserControlShift";
            this.Load += new System.EventHandler(this.UserControlShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftDemand)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ShiftDemand;
    }
}
