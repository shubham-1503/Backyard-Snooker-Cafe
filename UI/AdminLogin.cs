using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo3
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-QQ6IARCN\SQLEXPRESS;Initial Catalog=BSC;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbladmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelcrossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginAd_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txtUsername.Text;
            user_password = TxtPassword.Text;

            try
            {
                
                String query = "SELECT * FROM Admin_Registration_db WHERE username = '" + txtUsername.Text + "' AND password = '" + TxtPassword.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username= txtUsername.Text;
                    user_password= TxtPassword.Text;

                    AdminDashboard f5 = new AdminDashboard();
                    f5.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password","error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                    txtUsername.Clear();   
                    TxtPassword.Clear();    

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

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {
            AdminRegistration f4 = new AdminRegistration();
            f4.Show();
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            TxtPassword.Clear();

            txtUsername.Focus();
        }

        private void nextEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
