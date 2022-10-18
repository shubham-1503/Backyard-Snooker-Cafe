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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void labelcrossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers f6 = new ManageUsers();
            f6.Show();
        }

        private void btnMenuCard_Click(object sender, EventArgs e)
        {
            Menu f7 = new Menu();
            f7.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Analysis f8 = new Analysis();
            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemAnalysis f8 = new ItemAnalysis();
            f8.Show();
        }
    }
}
