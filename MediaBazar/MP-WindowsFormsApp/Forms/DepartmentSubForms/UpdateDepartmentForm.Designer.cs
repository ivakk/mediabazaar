namespace MP_WindowsFormsApp.Forms
{
    partial class UpdateDepartmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudRequiredPersonnel = new System.Windows.Forms.NumericUpDown();
            this.txtPositions = new System.Windows.Forms.TextBox();
            this.txtPointOfContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequiredPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(400, 27);
            this.txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 45);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.Size = new System.Drawing.Size(400, 80);
            this.txtDescription.TabIndex = 1;
            // 
            // nudRequiredPersonnel
            // 
            this.nudRequiredPersonnel.Location = new System.Drawing.Point(12, 131);
            this.nudRequiredPersonnel.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudRequiredPersonnel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRequiredPersonnel.Name = "nudRequiredPersonnel";
            this.nudRequiredPersonnel.Size = new System.Drawing.Size(400, 27);
            this.nudRequiredPersonnel.TabIndex = 2;
            this.nudRequiredPersonnel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPositions
            // 
            this.txtPositions.Location = new System.Drawing.Point(12, 164);
            this.txtPositions.Name = "txtPositions";
            this.txtPositions.PlaceholderText = "Positions";
            this.txtPositions.Size = new System.Drawing.Size(400, 27);
            this.txtPositions.TabIndex = 3;
            // 
            // txtPointOfContact
            // 
            this.txtPointOfContact.Location = new System.Drawing.Point(12, 197);
            this.txtPointOfContact.Name = "txtPointOfContact";
            this.txtPointOfContact.PlaceholderText = "Point Of Contact";
            this.txtPointOfContact.Size = new System.Drawing.Size(400, 27);
            this.txtPointOfContact.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UpdateDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 272);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPointOfContact);
            this.Controls.Add(this.txtPositions);
            this.Controls.Add(this.nudRequiredPersonnel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Name = "UpdateDepartmentForm";
            this.Text = "Update Department";
            ((System.ComponentModel.ISupportInitialize)(this.nudRequiredPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nudRequiredPersonnel;
        private System.Windows.Forms.TextBox txtPositions;
        private System.Windows.Forms.TextBox txtPointOfContact;
        private System.Windows.Forms.Button btnSave;
    }
}
