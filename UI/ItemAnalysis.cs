using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo3
{
    public partial class ItemAnalysis : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public ItemAnalysis()
        {
            InitializeComponent();
        }
        ItemAnalysisBLL i = new ItemAnalysisBLL();
        ItemAnalysisDAL idal = new ItemAnalysisDAL();

        private void lblItemAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void lblCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvItemAnalysis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemAnalysis_Load(object sender, EventArgs e)
        {
            DataTable dt = idal.Select();
            dgvItemAnalysis.DataSource = dt;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string dateFrom = FromDate.Value.ToString("MM-dd-yyyy");
            string dateTo = ToDate.Value.ToString("MM-dd-yyyy");

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            conn.Open();
            string sql = "SELECT * FROM Item1_Analysis WHERE Date BETWEEN @date1 and @date2";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@date1", dateFrom);
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTo);
            da.Fill(dt);
            conn.Close();
            dgvItemAnalysis.DataSource = dt;

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal colsum = 0;
            for (int r = 0; r < dgvItemAnalysis.Rows.Count; ++r)
            {
                colsum += Convert.ToDecimal(dgvItemAnalysis.Rows[r].Cells[4].Value);
            }
            txtRevenue.Text = colsum.ToString();

            decimal colsum1 = 0;
            for (int r = 0; r < dgvItemAnalysis.Rows.Count; ++r)
            {
                colsum1 += Convert.ToDecimal(dgvItemAnalysis.Rows[r].Cells[3].Value);
            }
            TxtOrders.Text = colsum1.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = idal.Search(keywords);
                dgvItemAnalysis.DataSource = dt;
            }
            else
            {
                DataTable dt = idal.Select();
                dgvItemAnalysis.DataSource = dt;
            }
        }
    }
}
