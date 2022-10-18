using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace demo3
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if(chkbxShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar=false;
            }
*/
            if (chkbxShowPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                txtVerify.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtVerify.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text == "victory")
            {
                SqlConnection connstring = new SqlConnection("Data Source=LAPTOP-QQ6IARCN\\SQLEXPRESS;Initial Catalog=BSC;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Admin_Registration_db]
           ([firstname]
           ,[lastname]
           ,[username]
           ,[password])
     VALUES
           ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtUserName.Text + "', '" + txtPass.Text + "')", connstring);
                connstring.Open();
                cmd.ExecuteNonQuery();
                connstring.Close();
                MessageBox.Show("Registration Successful");

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtUserName.Text = "";
                txtPass.Text = "";
                txtVerify.Text = "";
            }
            else
            {
                MessageBox.Show("Verification Password Incorrect");
            }
        
        }
        private void txtFirstName_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterNext(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
