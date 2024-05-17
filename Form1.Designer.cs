namespace crud
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGetProducts = new Button();
            btnAddProduct = new Button();
            dataGridView1 = new DataGridView();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtCategoryId = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            lblProductId = new Label();
            lblProductName = new Label();
            lblCategoryId = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetProducts
            // 
            btnGetProducts.BackColor = SystemColors.ActiveCaption;
            btnGetProducts.Location = new Point(315, 99);
            btnGetProducts.Name = "btnGetProducts";
            btnGetProducts.Size = new Size(100, 34);
            btnGetProducts.TabIndex = 0;
            btnGetProducts.Text = "Get Products";
            btnGetProducts.UseVisualStyleBackColor = false;
            btnGetProducts.Click += btnGetProducts_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Chartreuse;
            btnAddProduct.Location = new Point(315, 139);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(100, 34);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(460, 150);
            dataGridView1.TabIndex = 4;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(130, 60);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 27);
            txtProductId.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(130, 90);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 27);
            txtProductName.TabIndex = 6;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(130, 120);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(100, 27);
            txtCategoryId.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 150);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(130, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 27);
            txtDescription.TabIndex = 9;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(30, 63);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(79, 20);
            lblProductId.TabIndex = 10;
            lblProductId.Text = "Product ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(30, 93);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "Product Name";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(30, 123);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(88, 20);
            lblCategoryId.TabIndex = 12;
            lblCategoryId.Text = "Category ID";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 153);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 183);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description";
            // 
            // Form1
            // 
            ClientSize = new Size(520, 420);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblCategoryId);
            Controls.Add(lblProductName);
            Controls.Add(lblProductId);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtCategoryId);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddProduct);
            Controls.Add(btnGetProducts);
            Name = "Form1";
            Text = "Adding Product Application";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
