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
using System.Data.SqlClient;
using System.Configuration;

namespace demo3
{
    public partial class Analysis : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Analysis()
        {
            InitializeComponent();
        }
        AnalysisBLL a = new AnalysisBLL();
        AnalysisDAL adal = new AnalysisDAL();
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            
            DataTable dt = adal.Select();
            dgvAnalysis.DataSource = dt;
            
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string dateFrom = FromDate.Value.ToString("MM-dd-yyyy");
            string dateTo = ToDate.Value.ToString("MM-dd-yyyy");

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            conn.Open();
            string sql = "SELECT * FROM Analysis WHERE Date BETWEEN @date1 and @date2";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            da.SelectCommand.Parameters.AddWithValue("@date1",dateFrom);
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTo);
            da.Fill(dt);
            conn.Close();
            dgvAnalysis.DataSource = dt;

            textBox1.Text = $"{(dgvAnalysis.RowCount)-1}";

        }



        private void dgvAnalysis_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal colsum = 0;
            for (int r = 0; r < dgvAnalysis.Rows.Count; ++r)
            {
                colsum += Convert.ToDecimal(dgvAnalysis.Rows[r].Cells[4].Value);
            }
            txtTotal.Text = colsum.ToString();
        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {

        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FromDate_CloseUp(object sender, EventArgs e)
        {

        }

        private void ToDate_CloseUp(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAnalysis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
