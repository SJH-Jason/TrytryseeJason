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
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            IQueryable<User> query = new Model1().Users.AsNoTracking();

            query=query.OrderBy(x=>x.UserID);

            this.dataGridView1.DataSource = query.ToList();
        }
    }

    public class UserDto
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
    }
}
