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
        public int _SellerID = 10003;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int _shipmentid = (int)row.Cells[0].Value;
            int _orderid= (int)row.Cells[1].Value;

            //MessageBox.Show("Id=" + _shipmentid+_orderid);
            var frm = new ShipmentEdit();
            frm._shipmentid= _shipmentid;
            frm._orderid= _orderid;
            frm._sellerid = _SellerID;
            frm.ShowDialog();

        }

        private void btnTimeorder_Click(object sender, EventArgs e)
        {
            //用出貨單時間排序
            IQueryable<Shipment> query = new Model1().Shipments.AsQueryable();
            this.dataGridView1.DataSource = query.Where(c => c.SellerID == _SellerID).OrderByDescending(x=>x.ShipmentDate).ToList();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            //用出貨狀況排序
            IQueryable<Shipment> query = new Model1().Shipments.AsQueryable();
            this.dataGridView1.DataSource = query.Where(c => c.SellerID == _SellerID).OrderBy(x => x.CompletionStatus).ToList();
        }

     

        private void btnCompletion_Click(object sender, EventArgs e)
        {
            //用結單狀況排序
            IQueryable<Shipment> query = new Model1().Shipments.AsQueryable();
            this.dataGridView1.DataSource = query.Where(c => c.SellerID == _SellerID).OrderByDescending(x => x.ReceiveStatus).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IQueryable<Shipment> query = new Model1().Shipments.AsQueryable();
            int _shipmentid = Convert.ToInt32(txtSearch.Text);
            this.dataGridView1.DataSource = query.Where(c => c.SellerID == _SellerID && c.ShipmentID == _shipmentid).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
