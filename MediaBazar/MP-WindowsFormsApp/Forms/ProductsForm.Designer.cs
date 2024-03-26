namespace MP_WindowsFormsApp.Forms
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            cbSubCategory = new ComboBox();
            lbSubCategory = new Label();
            cbCategory = new ComboBox();
            label1 = new Label();
            cbBrand = new ComboBox();
            lblBrand = new Label();
            btnSearch = new Button();
            tbSearch = new TextBox();
            dgvProducts = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cbSubCategory);
            groupBox1.Controls.Add(lbSubCategory);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbBrand);
            groupBox1.Controls.Add(lblBrand);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1410, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(26, 122);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbSubCategory
            // 
            cbSubCategory.FormattingEnabled = true;
            cbSubCategory.Location = new Point(1049, 126);
            cbSubCategory.Name = "cbSubCategory";
            cbSubCategory.Size = new Size(203, 33);
            cbSubCategory.TabIndex = 8;
            cbSubCategory.Visible = false;
            // 
            // lbSubCategory
            // 
            lbSubCategory.AutoSize = true;
            lbSubCategory.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lbSubCategory.Location = new Point(853, 119);
            lbSubCategory.Name = "lbSubCategory";
            lbSubCategory.Size = new Size(190, 37);
            lbSubCategory.TabIndex = 7;
            lbSubCategory.Text = "Sub-category:";
            lbSubCategory.Visible = false;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(644, 126);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(203, 33);
            cbCategory.TabIndex = 6;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(502, 119);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 5;
            label1.Text = "Category:";
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(293, 126);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(203, 33);
            cbBrand.TabIndex = 4;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBrand.Location = new Point(191, 123);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(96, 37);
            lblBrand.TabIndex = 3;
            lblBrand.Text = "Brand:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Red;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1258, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            tbSearch.Location = new Point(26, 55);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(1226, 43);
            tbSearch.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Location = new Point(38, 227);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 35;
            dgvProducts.RowTemplate.ReadOnly = true;
            dgvProducts.Size = new Size(1358, 722);
            dgvProducts.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1259, 955);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Red;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1116, 955);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 43);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1258, 118);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 12;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 1000);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbSearch;
        private ComboBox cbSubCategory;
        private Label lbSubCategory;
        private ComboBox cbCategory;
        private Label label1;
        private ComboBox cbBrand;
        private Label lblBrand;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button button1;
    }
}