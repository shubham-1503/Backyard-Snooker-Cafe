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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        UserBLL u = new UserBLL();
        userDAL dal = new userDAL();

        private void lblCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            AdminDashboard f5 = new AdminDashboard();
            f5.Show();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.id = txtUserID.Text;
            u.firstname = txtFirstName.Text;
            u.lastname = txtLastName.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.email = txtEmail.Text;
            u.address = txtAddress.Text;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("User Added successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To Add User");
            }
            //Data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = txtUserID.Text;
            u.firstname = txtFirstName.Text;
            u.lastname = txtLastName.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.email = txtEmail.Text;
            u.address = txtAddress.Text;


            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("User Updated successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To Update User");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = txtUserID.Text;

            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("User deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed To delete User");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
