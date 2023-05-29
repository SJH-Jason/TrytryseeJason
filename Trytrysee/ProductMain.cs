using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trytrysee.EDModels;

namespace Trytrysee
{
    public partial class ProductMain : Form
    {
        private int _SellerID;
        public ProductMain(int sellerid)
        {
            InitializeComponent();
            _SellerID = sellerid;
        }

        private void ProductMain_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            IQueryable<Product> query = new Model1().Products.AsNoTracking();
            this.dataGridView1.DataSource = query.Where(c=>c.SellerID== _SellerID).ToList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var db = new Model1();
            var Product = new Product()
            {
                SellerID = _SellerID,
            };
            db.Products.Add(Product);
            db.SaveChanges();

            var frm= new ProductAdd(Product.ProductID, _SellerID);
            frm.ShowDialog();
        }
    }
}
