namespace demo3
{
    partial class Analysis
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
            this.panelAnalysis = new System.Windows.Forms.Panel();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.lblCrossBtn = new System.Windows.Forms.Label();
            this.dgvAnalysis = new System.Windows.Forms.DataGridView();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAnalysis
            // 
            this.panelAnalysis.BackColor = System.Drawing.Color.Navy;
            this.panelAnalysis.Controls.Add(this.lblAnalysis);
            this.panelAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnalysis.Location = new System.Drawing.Point(0, 0);
            this.panelAnalysis.Name = "panelAnalysis";
            this.panelAnalysis.Size = new System.Drawing.Size(1308, 124);
            this.panelAnalysis.TabIndex = 0;
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnalysis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysis.ForeColor = System.Drawing.Color.White;
            this.lblAnalysis.Location = new System.Drawing.Point(0, 0);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(1308, 124);
            this.lblAnalysis.TabIndex = 0;
            this.lblAnalysis.Text = "Analysis";
            this.lblAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblCrossBtn.TabIndex = 1;
            this.lblCrossBtn.Text = "x";
            this.lblCrossBtn.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAnalysis
            // 
            this.dgvAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalysis.Location = new System.Drawing.Point(446, 155);
            this.dgvAnalysis.Name = "dgvAnalysis";
            this.dgvAnalysis.RowHeadersWidth = 62;
            this.dgvAnalysis.RowTemplate.Height = 28;
            this.dgvAnalysis.Size = new System.Drawing.Size(840, 503);
            this.dgvAnalysis.TabIndex = 4;
            this.dgvAnalysis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnalysis_CellContentClick);
            this.dgvAnalysis.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAnalysis_RowHeaderMouseClick);
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "MM/dd/yyyy";
            this.FromDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(169, 191);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(204, 33);
            this.FromDate.TabIndex = 6;
            this.FromDate.CloseUp += new System.EventHandler(this.FromDate_CloseUp);
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(41, 198);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(123, 26);
            this.lblFromDate.TabIndex = 7;
            this.lblFromDate.Text = "From Date";
            this.lblFromDate.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(41, 273);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(95, 26);
            this.lblToDate.TabIndex = 9;
            this.lblToDate.Text = "To Date";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "MM/dd/yyyy";
            this.ToDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(169, 266);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(204, 33);
            this.ToDate.TabIndex = 8;
            this.ToDate.CloseUp += new System.EventHandler(this.ToDate_CloseUp);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Green;
            this.btnCalc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(48, 612);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(133, 46);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Total";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(210, 615);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(187, 41);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Black;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(151, 346);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(114, 49);
            this.btnshow.TabIndex = 12;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(31, 434);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(234, 26);
            this.lblTransactions.TabIndex = 14;
            this.lblTransactions.Text = "No. of Transactions :";
            this.lblTransactions.Click += new System.EventHandler(this.lblTransactions_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(271, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 30);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1308, 696);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.dgvAnalysis);
            this.Controls.Add(this.lblCrossBtn);
            this.Controls.Add(this.panelAnalysis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            this.panelAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAnalysis;
        private System.Windows.Forms.Label lblAnalysis;
        private System.Windows.Forms.Label lblCrossBtn;
        private System.Windows.Forms.DataGridView dgvAnalysis;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.TextBox textBox1;
    }
}