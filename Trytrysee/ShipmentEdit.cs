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
    public partial class ShipmentEdit : Form
    {
       
        public ShipmentEdit()
        {
            InitializeComponent();
        }

        private void Shipment_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display() 
        {
           
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            txtAction1.Text= "已出貨";
            btnShip.Enabled= false;
            txtTime2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            btnArrival.Enabled= true;
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            txtAction2.Text = "已送達";
            btnArrival.Enabled=false;
            txtTime3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            btnCompletion.Enabled= true;
        }

        private void btnCompletion_Click(object sender, EventArgs e)
        {
            txtAction3.Text = "已完成";
            btnCompletion.Enabled=false;
            txtTime4.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

