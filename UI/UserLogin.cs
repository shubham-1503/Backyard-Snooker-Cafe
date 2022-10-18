using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo3
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QQ6IARCN\SQLEXPRESS;Initial Catalog=BSC;Integrated Security=True");

        private void labelcrossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txtUsername.Text;
            user_password = txtPassword.Text;

            try
            {

                String query = "SELECT * FROM Manage_Users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    user_password = txtPassword.Text;

                    Billing f5 = new Billing();
                    f5.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();

                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
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
