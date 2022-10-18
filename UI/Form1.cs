using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3
{
    public partial class BillingPOS : Form
    {
        public BillingPOS()
        {
            InitializeComponent();
        }

        private void lblCreatedBy_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin f2 = new AdminLogin();
            f2.Show();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            UserLogin f3 = new UserLogin();
            f3.Show();
        }

        private void BillingPOS_Load(object sender, EventArgs e)
        {

        }
    }
}
