using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trytrysee.EDModels;

namespace Trytrysee
{
    public partial class ProductAdd : Form
    {
        private int _ProductID;
        private int _SellerID;
        public ProductAdd(int productid,int sellerid)
        {
            InitializeComponent();
            _ProductID= productid;
            _SellerID= sellerid;
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            IQueryable<Product> query = new Model1().Products.AsNoTracking();

            _ProductID = query.OrderByDescending(c => c.ProductID).Select(c => c.ProductID).FirstOrDefault();
            _SellerID= (int)query.OrderByDescending(c => c.ProductID).Select(c => c.SellerID).FirstOrDefault();
            txtProductId.Text = _ProductID.ToString();
            MessageBox.Show($"{_SellerID}");

            var product = new Model1()
                            .Products
                            .AsNoTracking()
                            .Where(c => c.ProductID == _ProductID)
                            .SingleOrDefault();
            txtProductName.Text = product.ProductName;
            txtCategoryId.Text = product.CategoryID;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtProductDescription.Text = product.ProductDescription;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new Model1 ();

            string name = txtProductName.Text;
            string categoryId = txtCategoryId.Text;
            string description = txtProductDescription.Text;
            bool isInt = int.TryParse(txtProductPrice.Text, out int price);

            // 更新記錄
            var product = db.Products.Find(_ProductID);
            product.ProductName= name;
            product.CategoryID= categoryId;
            product.ProductDescription= description;
            product.ProductPrice= price;

            db.SaveChanges();

            //新增進貨
            if (txtProductQuantity.Text != string.Empty)
            {
                var productinventory = new ProductInventory()
                {
                    ProductID = Convert.ToInt32(txtProductId.Text),
                    SellerID = _SellerID,
                    Quantity = Convert.ToInt32(txtProductQuantity.Text),
                };

                db.ProductInventories.Add(productinventory);
                db.SaveChanges();
            }

                MessageBox.Show("已更新完成!");
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            label7.Visible= !label7.Visible;
            txtProductQuantity.Visible= !txtProductQuantity.Visible;
            txtProductName.Enabled= !txtProductName.Enabled;
            txtCategoryId.Enabled= !txtCategoryId.Enabled;
            txtProductPrice.Enabled= !txtProductPrice.Enabled;
            txtProductDescription.Enabled= !txtProductDescription.Enabled;

            if(label7.Visible)
            {
                txtProductQuantity.Focus();
            }
            else
            {
                txtProductName.Focus();
            }
        }
    }
}
