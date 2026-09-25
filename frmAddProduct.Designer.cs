namespace Inventory
{
    partial class frmAddProduct
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
            lblTitle = new Label();
            lblProduct = new Label();
            lblCategory = new Label();
            lblMfgDate = new Label();
            lblExpDate = new Label();
            lblQty = new Label();
            lblSellPrice = new Label();
            lblDescription = new Label();
            txtProductName = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Product";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(14, 52);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(47, 13);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Product";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(14, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(53, 13);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblMfgDate
            // 
            lblMfgDate.AutoSize = true;
            lblMfgDate.Location = new Point(14, 114);
            lblMfgDate.Name = "lblMfgDate";
            lblMfgDate.Size = new Size(58, 13);
            lblMfgDate.TabIndex = 3;
            lblMfgDate.Text = "Mfg. Date";
            // 
            // lblExpDate
            // 
            lblExpDate.AutoSize = true;
            lblExpDate.Location = new Point(14, 144);
            lblExpDate.Name = "lblExpDate";
            lblExpDate.Size = new Size(55, 13);
            lblExpDate.TabIndex = 4;
            lblExpDate.Text = "Exp. Date";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(14, 175);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(24, 13);
            lblQty.TabIndex = 5;
            lblQty.Text = "Qty";
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Location = new Point(14, 206);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(52, 13);
            lblSellPrice.TabIndex = 6;
            lblSellPrice.Text = "Sell Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(392, 52);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(66, 13);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(92, 49);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(275, 22);
            txtProductName.TabIndex = 8;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(92, 79);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(275, 21);
            cbCategory.TabIndex = 9;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Format = DateTimePickerFormat.Short;
            dtPickerMfgDate.Location = new Point(92, 109);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(275, 22);
            dtPickerMfgDate.TabIndex = 10;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Format = DateTimePickerFormat.Short;
            dtPickerExpDate.Location = new Point(92, 139);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(275, 22);
            dtPickerExpDate.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(92, 172);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(275, 22);
            txtQuantity.TabIndex = 12;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(92, 203);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(275, 22);
            txtSellPrice.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(395, 76);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(427, 149);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(736, 231);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(86, 26);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(17, 274);
            gridViewProductList.MultiSelect = false;
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersVisible = false;
            gridViewProductList.RowHeadersWidth = 51;
            gridViewProductList.Size = new Size(805, 140);
            gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 431);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtProductName);
            Controls.Add(lblDescription);
            Controls.Add(lblSellPrice);
            Controls.Add(lblQty);
            Controls.Add(lblExpDate);
            Controls.Add(lblMfgDate);
            Controls.Add(lblCategory);
            Controls.Add(lblProduct);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}