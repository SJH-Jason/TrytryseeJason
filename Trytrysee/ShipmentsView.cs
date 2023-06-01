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
    public partial class ShipmentsView : Form
    {
        private int _SellerID = 10003;
        public ShipmentsView()
        {
            InitializeComponent();
        }

        private void ShipmentsView_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            IQueryable<Shipment> query = new Model1().Shipments.AsQueryable();
            this.dataGridView1.DataSource = query.Where(c => c.SellerID == _SellerID).ToList();
        }
    }
}
