using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trytrysee.EDModels;

namespace Trytrysee
{
    public partial class SellerMain : Form
    {
        private List<SellerDto> data;
        public SellerMain()
        {
            InitializeComponent();
        }

        private void SellerMain_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateSeller();
            frm.ShowDialog();

        }

        public void Display()
        {
            int? SellerId = null;
            if(int.TryParse(this.txtSellerId.Text,out int num))
            {
                SellerId = num;
            }

            string SellerName=this.txtSellerName.Text;

            IQueryable<Seller> query = new Model1().Sellers.AsNoTracking();

            if(SellerId.HasValue)
            {
                query = query.Where(c => c.SellerID == SellerId.Value);
            }

            if (string.IsNullOrEmpty(SellerName) == false)
            {
                query = query.Where(c => c.SellerName.Contains(SellerName));
            }

            query = query.OrderBy(x => x.SellerID);

            this.data=query.ToList()
                .Select(c=>new SellerDto { SellerID=c.SellerID,SellerName=c.SellerName,
                    SellerAccount=c.SellerAccount,SellerPassword=c.SellerPassword,
                    SellerContact=c.SellerContact }).ToList();

            this.dataGridView1.DataSource = query.ToList();
        }
    }

    public class SellerDto
    {
        public int SellerID { get; set; }

        public string SellerName { get; set; }

        public string SellerAccount { get; set; }

        public string SellerPassword { get; set; }

        public string SellerContact { get; set; }
    }
}
