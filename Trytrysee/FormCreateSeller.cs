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
    public partial class FormCreateSeller : Form
    {
        public FormCreateSeller()
        {
            InitializeComponent();
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            string SellerName=txtaddSellerName.Text;
            string SellerAccount=txtAddSellerAccount.Text;
            string SellerPassword=txtAddSellerPassword.Text;
            string SellerContact=txtAddSellerContact.Text;

            if(SellerName==string.Empty||SellerAccount==string.Empty||SellerPassword==string.Empty
                ||SellerContact==string.Empty)
            {
                MessageBox.Show("請輸入完整資訊!");
                return;
            }

            var db = new Model1();
            var Seller = new Seller()
            {
                SellerName = SellerName,
                SellerAccount = SellerAccount,
                SellerPassword = SellerPassword,
                SellerContact = SellerContact,
            };

            db.Sellers.Add( Seller );
            db.SaveChanges();

        }
    }
}
