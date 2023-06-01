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
using static System.Windows.Forms.ListViewItem;

namespace Trytrysee
{
    public partial class FormSellerPage : Form
    {
        private int _SellerID = 10003;
        public FormSellerPage()
        {
            InitializeComponent();
        }

        private void FormSellerPage_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            IQueryable<Seller> query = new Model1().Sellers.AsNoTracking();
            txtSellerID.Text = query.Where(c => c.SellerID == _SellerID).Select(a=>a.SellerID).FirstOrDefault().ToString();
            txtSellerName.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerName).FirstOrDefault();
            txtSellerAccount.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerAccount).FirstOrDefault();
            txtSellerPassword.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerPassword).FirstOrDefault();
            txtSellerContact.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerContact).FirstOrDefault();

        }

        private void btnProductMain_Click(object sender, EventArgs e)
        {
            var frm=new ProductMain(_SellerID);
            frm.ShowDialog();
        }

        private void btnShipments_Click(object sender, EventArgs e)
        {
            var frm = new ShipmentEdit();
            frm.ShowDialog();
        }
    }
    }

