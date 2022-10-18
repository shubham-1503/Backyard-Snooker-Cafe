using demo3.BLL;
using demo3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace demo3
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        BillingBLL u = new BillingBLL();
        BillingDAL dal = new BillingDAL();
        
        AnalysisBLL a = new AnalysisBLL();
        AnalysisDAL adal = new AnalysisDAL();

        ItemAnalysisBLL i = new ItemAnalysisBLL();
        ItemAnalysisDAL idal = new ItemAnalysisDAL();

      

        private void lblCrossbtm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvItemDisplay.DataSource = dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            u.Item_Id = txtItemID.Text;
            u.Item_Name = txtItemName.Text;
            u.Quantity = decimal.Parse(txtQtn.Text);
            u.Rate = decimal.Parse(txtRate.Text);
            u.Total = u.Rate*u.Quantity;


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
            dgvItemDisplay.DataSource = dt;

            decimal colsum = 0;
            for(int r = 0; r < dgvItemDisplay.Rows.Count; ++r)
            {
                colsum +=  Convert.ToDecimal(dgvItemDisplay.Rows[r].Cells[4].Value);
            }
            txtSubTotal.Text = colsum.ToString();

        }

        private void clear()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtQtn.Text = "";
            txtRate.Text = "";
            txtTotal.Text = "";
            txtSearch.Text = "";


        }
        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            u.Item_Name = txtItemName.Text;

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
            dgvItemDisplay.DataSource = dt;

            decimal colsum = 0;
            for (int r = 0; r < dgvItemDisplay.Rows.Count; ++r)
            {
                colsum += Convert.ToDecimal(dgvItemDisplay.Rows[r].Cells[4].Value);
            }
            txtSubTotal.Text = colsum.ToString();
        }

        private void dgvItemDisplay_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtItemID.Text = dgvItemDisplay.Rows[rowIndex].Cells[0].Value.ToString();
            txtItemName.Text = dgvItemDisplay.Rows[rowIndex].Cells[1].Value.ToString();
            txtQtn.Text = dgvItemDisplay.Rows[rowIndex].Cells[2].Value.ToString();
            txtRate.Text = dgvItemDisplay.Rows[rowIndex].Cells[3].Value.ToString();
            txtTotal.Text = dgvItemDisplay.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void nextEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords =="")
            {
                txtItemID.Text = "";
                txtItemName.Text = "";
                txtQtn.Text = "";
                txtRate.Text = "";

                return;
            }

            BillingBLL p = dal.GetItemsForBillling(keywords);

            txtItemID.Text = p.Item_Id;
            txtItemName.Text = p.Item_Name;
            txtRate.Text = p.Rate.ToString();

        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtSubTotal.Text != "")
            { 

                string value = txtDiscount.Text;
                if(value == "")
                {
                  MessageBox.Show("Add Discount Value");
 

                }
                else
                {
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    decimal discount = decimal.Parse(txtDiscount.Text);

                // decimal grandTotal = ((100 - discount) / 100) * subtotal;
                 
                // txtGrandTotal.Text = grandTotal.ToString();
                }
            }
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            a.Bill_No = txtBillNo.Text;
            a.Customer_Name = txtCustName.Text;
            a.Customer_Contact = txtCustContact.Text;
            a.Date = DateTime.Now;
            a.Grand_Total = decimal.Parse(txtGrandTotal.Text);

            bool success = adal.Insert(a);
 

            if (success == true)
            {
                MessageBox.Show("Details saved successfully");
            }
            else
            {
                MessageBox.Show("Failed To Save Details");
            }



            ////i.Date = DateTime.Now;

            /*
            bool good = idal.Insert(i);

            if (good == true)
            {
                MessageBox.Show("Item Details saved successfully");
            }
            else
            {
                MessageBox.Show("Failed To Save Item Details");
            }
            */

            
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QQ6IARCN\SQLEXPRESS;Initial Catalog=BSC;Integrated Security=True");
           // SqlConnection conn = new SqlConnection(myconnstring);
            for (int j = 0; j < dgvItemDisplay.Rows.Count -1 ; j++)
            {

                                
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Item1_Analysis (Date, Item_id, Item_name, Quantity, Total)VALUES(@Date,'" + dgvItemDisplay.Rows[j].Cells[0].Value+ "','" + dgvItemDisplay.Rows[j].Cells[1].Value + "','" + dgvItemDisplay.Rows[j].Cells[2].Value + "','" + dgvItemDisplay.Rows[j].Cells[4].Value + "')",con);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }


            /*
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                for (int j = 0; j < dgvItemDisplay.Rows.Count - 1; j++)
                {

                }
                
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
            */
        }

        private void clear1()
        {
           
            txtCustName.Text = "";
            txtCustContact.Text = "";
            txtGrandTotal.Text = "";
            txtSubTotal.Text = "";
            txtDiscount.Text = "";
            txtTax.Text = "";


        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            if (txtSubTotal.Text != "")
            {
                string check = txtTax.Text;
                if (check == "")
                {
                    MessageBox.Show("Enter Tax Value");
                }
                else
                {
                    decimal subtotal = decimal.Parse(txtSubTotal.Text);
                    decimal discount = decimal.Parse(txtDiscount.Text);

                    decimal previousGT = ((100 - discount) / 100) * subtotal;
                    decimal tax = decimal.Parse(txtTax.Text);
                    decimal grandtotal = ((100 + tax) / 100) * previousGT;

                    txtGrandTotal.Text = grandtotal.ToString("0.00");
                }
            }
        }

        private void txtSubTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {




        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm" , 285, 600);
            printPreviewDialog1.ShowDialog();

            clear1();
            // dgvItemDisplay.Rows.Clear();

            //  dgvItemDisplay.Refresh();

            //dgvItemDisplay.DataSource = null;

            //dgvItemDisplay.Columns.Clear();

            /*
            var dtdgv = dgvItemDisplay.DataSource as DataTable;
            dtdgv.Rows.Clear();
            dgvItemDisplay.DataSource = dtdgv;
            */

            SqlConnection conn = new SqlConnection(myconnstring);
            string sql = "DELETE FROM Bill";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            //dgvItemDisplay.Refresh();
            DataTable dt = dal.Select();
            dgvItemDisplay.DataSource = dt;
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Arial", 8);

            


            //Call method to Draw Headers
            drawHeader(new Font("Arial", 8, FontStyle.Regular), graphic);

            //Call method to Draw DataGrid
            drawDataGridTab2(new Font("Arial", 8, FontStyle.Regular), graphic);



           


            Pen blackPen = new Pen(Color.Black, 1);
           // int X1 = 5, Y1 = 85, X2 = 280, Y2 = 85;



            e.Graphics.DrawString("BACKYARD SNOOKER CAFE", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(13, 10));
           // e.Graphics.DrawString("Plot No. 132/AB Kandivali cooperative industrial estate limited, Charkop Gaon, Mumbai, Maharashtra 400067", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, 50));

            Graphics gf = e.Graphics;
            SizeF sf = gf.MeasureString("Plot No. 132/AB Kandivali cooperative industrial estate limited, Charkop Gaon, Mumbai, Maharashtra, 400067", new Font(new FontFamily("Arial"), 8), 250);
            gf.DrawString("Plot No. 132/AB Kandivali cooperative industrial estate limited, Charkop Gaon, Mumbai, Maharashtra, 400067", new Font(new FontFamily("Arial"), 8), Brushes.Black,new RectangleF(new PointF(25, 40), sf),StringFormat.GenericTypographic);

            e.Graphics.DrawString("Contact: +91 9594565964", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(80, 85));

            e.Graphics.DrawLine(blackPen, 5, 105, 280, 105);
            e.Graphics.DrawLine(blackPen, 5, 110, 280, 110);

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Customer Name : " + txtCustName.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 135));

            e.Graphics.DrawLine(blackPen, 5, 155, 280, 155);
            e.Graphics.DrawLine(blackPen, 5, 160, 280, 160);

            // drawDataGridTab2(new Font("Courier New", 10, FontStyle.Bold), graphic);
            e.Graphics.DrawLine(blackPen, 5, 485, 280, 485);
            e.Graphics.DrawLine(blackPen, 5, 490, 280, 490);
            e.Graphics.DrawString("Sub Total : " + txtSubTotal.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 500));
            e.Graphics.DrawString("Discount(%) : " + txtDiscount.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 520));
            e.Graphics.DrawString("Tax(%) : " + txtTax.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 540));
            e.Graphics.DrawString("Grand Total : " + txtGrandTotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 560));
            
        }

        private void drawHeader(Font font, Graphics graphic)
        {
            graphic.DrawString("Sr", font, Brushes.Black, 5, 170);
            string Item_Name = dgvItemDisplay.Columns["Item_Name"].HeaderText;
            graphic.DrawString(Item_Name, font, Brushes.Black, 25, 170);
            string Qtn = dgvItemDisplay.Columns["Quantity"].HeaderText;
            graphic.DrawString(Qtn, font, Brushes.Black, 110, 170);
            string Rate = dgvItemDisplay.Columns["Rate"].HeaderText;
            graphic.DrawString(Rate, font, Brushes.Black, 175, 170);
            string Total = dgvItemDisplay.Columns["Total"].HeaderText;
            graphic.DrawString(Total, font, Brushes.Black, 230, 170);
            //throw new NotImplementedException();
        }
  
        private void drawDataGridTab2(Font font, Graphics g)
        {
            
            int yCord = 190;
            int y1 = 185;
            int y2 = 185;
            int rows = 1;
            foreach (DataGridViewRow dr in dgvItemDisplay.Rows)
            {
                if (dr.IsNewRow)
                    continue;
                
                // g.DrawString(dr.ToString(), new Font("Arial", 10), Brushes.Black, 10, 150);
                g.DrawString(rows.ToString(), font, Brushes.Black, 5, yCord);
                string Item_Name = dgvItemDisplay.Rows[dr.Index].Cells["Item_Name"].FormattedValue.ToString();
                g.DrawString(Item_Name, font, Brushes.Black, 25, yCord);
                string Qtn = dgvItemDisplay.Rows[dr.Index].Cells["Quantity"].FormattedValue.ToString();
                g.DrawString(Qtn, font, Brushes.Black, 110, yCord);
                string Rate = dgvItemDisplay.Rows[dr.Index].Cells["Rate"].FormattedValue.ToString();
                g.DrawString(Rate, font, Brushes.Black, 175, yCord);
                string Total = dgvItemDisplay.Rows[dr.Index].Cells["Total"].FormattedValue.ToString();
                g.DrawString(Total, font, Brushes.Black, 230, yCord);
               // g.DrawLine(new Pen(Color.Black, 1), 0, y1, this.Width, y2);
                yCord += 15;
                y1 += 15;
                y2 += 15;
                rows++;
            }
      

          
        }

        private void dgvItemDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
