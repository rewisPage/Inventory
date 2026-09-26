using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        // Table 2 Variables
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        // BindingSource instance
        private BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // Table 3 Categories
            string[] ListOfProductCategory = new string[]
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }

        // Methods adapted from the lab's Method.txt with custom exception triggers
        public string Product_Name(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                throw new StringFormatException("Invalid product name format. Only letters are allowed.");
            }
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$"))
            {
                throw new NumberFormatException("Invalid quantity format. Only positive integers are allowed.");
            }
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^(\d+(\.\d{1,2})?)$"))
            {
                throw new CurrencyFormatException("Invalid price format. Expected standard currency (e.g. 10 or 10.50).");
            }
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(
                    _ProductName,
                    _Category,
                    _MfgDate,
                    _ExpDate,
                    _SellPrice,
                    _Quantity,
                    _Description
                ));

                // Return if no category is selected
                if (cbCategory.Text == "")
                {
                    MessageBox.Show("Please select a category.", "Category Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Return if manufacturing date is later than expiration date
                if (dtPickerMfgDate.Value > dtPickerExpDate.Value)
                {
                    MessageBox.Show("Manufacturing date cannot be later than expiration date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;

                // Clear input controls after successful insertion
                txtProductName.Clear();
                txtQuantity.Clear();
                txtSellPrice.Clear();
                richTxtDescription.Clear();
                cbCategory.SelectedIndex = -1;
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "String Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Currency Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}