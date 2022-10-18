using demo3.BLL;
using demo3.DAL;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        MenuBLL u = new MenuBLL();
        MenuDAL dal = new MenuDAL();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvMenu.DataSource = dt;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            AdminDashboard f5 = new AdminDashboard();
            f5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.id = txtItemID.Text;
            u.itemname = txtItemName.Text;
            u.category = comboBoxCategory.Text;
            u.rate = decimal.Parse(txtRate.Text);
;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("Item Added successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To Add Item");
            }
            //Data grid view
            DataTable dt = dal.Select();
            dgvMenu.DataSource = dt;
        }
        private void clear()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            comboBoxCategory.Text = "";
            txtRate.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtItemID.Text = dgvMenu.Rows[rowIndex].Cells[0].Value.ToString();
            txtItemName.Text = dgvMenu.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxCategory.Text = dgvMenu.Rows[rowIndex].Cells[2].Value.ToString();
            txtRate.Text = dgvMenu.Rows[rowIndex].Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = txtItemID.Text;
            u.itemname = txtItemName.Text;
            u.category = comboBoxCategory.Text;
            u.rate = decimal.Parse(txtRate.Text);



            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("Item Updated successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To Update Item");
            }
            DataTable dt = dal.Select();
            dgvMenu.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = txtItemID.Text;

            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("Item deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To delete Item");
            }
            DataTable dt = dal.Select();
            dgvMenu.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords!= null)
            {
                DataTable dt = dal.Search(keywords);
                dgvMenu.DataSource=dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvMenu.DataSource = dt;
            }
        }

        private void nextEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
