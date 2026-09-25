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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(14, 52);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(47, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 82);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.Location = new System.Drawing.Point(14, 114);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(54, 13);
            this.lblMfgDate.TabIndex = 3;
            this.lblMfgDate.Text = "Mfg. Date";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(14, 144);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(54, 13);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "Exp. Date";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(14, 175);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Qty";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(14, 206);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(53, 13);
            this.lblSellPrice.TabIndex = 6;
            this.lblSellPrice.Text = "Sell Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(340, 52);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(92, 49);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(217, 22);
            this.txtProductName.TabIndex = 8;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(92, 79);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(217, 21);
            this.cbCategory.TabIndex = 9;
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerMfgDate.Location = new System.Drawing.Point(92, 109);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(217, 22);
            this.dtPickerMfgDate.TabIndex = 10;
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerExpDate.Location = new System.Drawing.Point(92, 139);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(217, 22);
            this.dtPickerExpDate.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(92, 172);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(217, 22);
            this.txtQuantity.TabIndex = 12;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(92, 203);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(217, 22);
            this.txtSellPrice.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(343, 76);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(243, 149);
            this.richTxtDescription.TabIndex = 14;
            this.richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(500, 237);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(86, 26);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.Location = new System.Drawing.Point(17, 274);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.RowHeadersWidth = 51;
            this.gridViewProductList.Size = new System.Drawing.Size(569, 140);
            this.gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.gridViewProductList);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblMfgDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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