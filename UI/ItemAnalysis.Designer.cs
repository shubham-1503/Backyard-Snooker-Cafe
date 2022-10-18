namespace demo3
{
    partial class ItemAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCrossBtn = new System.Windows.Forms.Label();
            this.lblItemAnalysis = new System.Windows.Forms.Label();
            this.dgvItemAnalysis = new System.Windows.Forms.DataGridView();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.TxtOrders = new System.Windows.Forms.TextBox();
            this.LblRevenue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblCrossBtn);
            this.panel1.Controls.Add(this.lblItemAnalysis);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 124);
            this.panel1.TabIndex = 0;
            // 
            // lblCrossBtn
            // 
            this.lblCrossBtn.AutoSize = true;
            this.lblCrossBtn.BackColor = System.Drawing.Color.Navy;
            this.lblCrossBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCrossBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrossBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCrossBtn.Location = new System.Drawing.Point(1264, 0);
            this.lblCrossBtn.Name = "lblCrossBtn";
            this.lblCrossBtn.Size = new System.Drawing.Size(41, 46);
            this.lblCrossBtn.TabIndex = 2;
            this.lblCrossBtn.Text = "x";
            this.lblCrossBtn.Click += new System.EventHandler(this.lblCrossBtn_Click);
            // 
            // lblItemAnalysis
            // 
            this.lblItemAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemAnalysis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAnalysis.ForeColor = System.Drawing.Color.White;
            this.lblItemAnalysis.Location = new System.Drawing.Point(0, 0);
            this.lblItemAnalysis.Name = "lblItemAnalysis";
            this.lblItemAnalysis.Size = new System.Drawing.Size(1308, 124);
            this.lblItemAnalysis.TabIndex = 1;
            this.lblItemAnalysis.Text = "Item Analysis";
            this.lblItemAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemAnalysis.Click += new System.EventHandler(this.lblItemAnalysis_Click);
            // 
            // dgvItemAnalysis
            // 
            this.dgvItemAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemAnalysis.Location = new System.Drawing.Point(446, 155);
            this.dgvItemAnalysis.Name = "dgvItemAnalysis";
            this.dgvItemAnalysis.RowHeadersWidth = 62;
            this.dgvItemAnalysis.RowTemplate.Height = 28;
            this.dgvItemAnalysis.Size = new System.Drawing.Size(840, 503);
            this.dgvItemAnalysis.TabIndex = 5;
            this.dgvItemAnalysis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemAnalysis_CellContentClick);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(20, 538);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(199, 30);
            this.lblOrders.TabIndex = 23;
            this.lblOrders.Text = "No. of Orders :";
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Black;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(170, 294);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(114, 49);
            this.btnshow.TabIndex = 22;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // txtRevenue
            // 
            this.txtRevenue.BackColor = System.Drawing.Color.White;
            this.txtRevenue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.Location = new System.Drawing.Point(229, 612);
            this.txtRevenue.Multiline = true;
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(187, 41);
            this.txtRevenue.TabIndex = 21;
            this.txtRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Green;
            this.btnCalc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(109, 462);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(219, 46);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(32, 228);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(95, 26);
            this.lblToDate.TabIndex = 19;
            this.lblToDate.Text = "To Date";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "MM/dd/yyyy";
            this.ToDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(212, 223);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(204, 33);
            this.ToDate.TabIndex = 18;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(32, 160);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(123, 26);
            this.lblFromDate.TabIndex = 17;
            this.lblFromDate.Text = "From Date";
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "MM/dd/yyyy";
            this.FromDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(212, 155);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(204, 33);
            this.FromDate.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(170, 375);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 33);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(33, 378);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 26);
            this.lblSearch.TabIndex = 48;
            this.lblSearch.Text = "Search";
            // 
            // TxtOrders
            // 
            this.TxtOrders.BackColor = System.Drawing.Color.White;
            this.TxtOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrders.Location = new System.Drawing.Point(230, 532);
            this.TxtOrders.Multiline = true;
            this.TxtOrders.Name = "TxtOrders";
            this.TxtOrders.Size = new System.Drawing.Size(187, 41);
            this.TxtOrders.TabIndex = 50;
            this.TxtOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRevenue
            // 
            this.LblRevenue.AutoSize = true;
            this.LblRevenue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRevenue.Location = new System.Drawing.Point(17, 618);
            this.LblRevenue.Name = "LblRevenue";
            this.LblRevenue.Size = new System.Drawing.Size(201, 30);
            this.LblRevenue.TabIndex = 52;
            this.LblRevenue.Text = "Total Revenue:";
            // 
            // ItemAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1308, 696);
            this.Controls.Add(this.LblRevenue);
            this.Controls.Add(this.TxtOrders);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.dgvItemAnalysis);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemAnalysis";
            this.Load += new System.EventHandler(this.ItemAnalysis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblItemAnalysis;
        private System.Windows.Forms.Label lblCrossBtn;
        private System.Windows.Forms.DataGridView dgvItemAnalysis;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox TxtOrders;
        private System.Windows.Forms.Label LblRevenue;
    }
}