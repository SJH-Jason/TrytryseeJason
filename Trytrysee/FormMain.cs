using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trytrysee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var frm= new UserMain();
            frm.ShowDialog();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            var frm = new SellerMain();
            frm.ShowDialog();
        }
    }
}
