using demo3.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3.DAL
{
    internal class userDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
                
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Manage_Users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data in Database
        public bool Insert(UserBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO Manage_Users (id, firstname, lastname, username, password, contact, email, address) VALUES (@id, @firstname, @lastname, @username, @password, @contact, @email, @address)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@firstname", u.firstname);
                cmd.Parameters.AddWithValue("@lastname", u.lastname);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@address", u.address);

                conn.Open ();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conn.Close ();
            }
            return isSuccess;
        }
        #endregion
        #region Update data in Database
        public bool Update(UserBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection (myconnstring);

            try
            {
                string sql = "UPDATE Manage_Users SET firstname=@firstname, lastname=@lastname, username=@username, password=@password, contact=@contact, email=@email, address=@address WHERE id=@id";
                SqlCommand cmd = new SqlCommand (sql, conn);

                cmd.Parameters.AddWithValue("@firstname", u.firstname);
                cmd.Parameters.AddWithValue("@lastname", u.lastname);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open ();

                int rows = cmd.ExecuteNonQuery ();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Delete data from Database
        public bool Delete(UserBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection (myconnstring);
            try
            {
                string sql = "DELETE FROM Manage_Users WHERE id=@id";

                SqlCommand cmd = new SqlCommand (sql, conn);

                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open ();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess=true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        #endregion


    }
}
