namespace demo3
{
    partial class BillingPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingPOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBSC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblCreatedBy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 980);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::demo3.Properties.Resources.vp_logo1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Black", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(0, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(1924, 70);
            this.lblCreatedBy.TabIndex = 1;
            this.lblCreatedBy.Text = "-Created By Virtual Partners";
            this.lblCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreatedBy.Click += new System.EventHandler(this.lblCreatedBy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // labelBSC
            // 
            this.labelBSC.AutoSize = true;
            this.labelBSC.BackColor = System.Drawing.Color.Black;
            this.labelBSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBSC.ForeColor = System.Drawing.Color.White;
            this.labelBSC.Location = new System.Drawing.Point(581, 34);
            this.labelBSC.Name = "labelBSC";
            this.labelBSC.Size = new System.Drawing.Size(814, 82);
            this.labelBSC.TabIndex = 3;
            this.labelBSC.Text = "Backyard Snooker Cafe";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonUserLogin);
            this.panel2.Controls.Add(this.buttonAdminLogin);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(306, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 696);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::demo3.Properties.Resources.snookertable;
            this.pictureBox1.Location = new System.Drawing.Point(745, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.BackColor = System.Drawing.Color.Green;
            this.buttonUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserLogin.ForeColor = System.Drawing.Color.White;
            this.buttonUserLogin.Location = new System.Drawing.Point(897, 527);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Padding = new System.Windows.Forms.Padding(10);
            this.buttonUserLogin.Size = new System.Drawing.Size(255, 74);
            this.buttonUserLogin.TabIndex = 2;
            this.buttonUserLogin.Text = "User Login";
            this.buttonUserLogin.UseVisualStyleBackColor = false;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.BackColor = System.Drawing.Color.Green;
            this.buttonAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminLogin.ForeColor = System.Drawing.Color.White;
            this.buttonAdminLogin.Location = new System.Drawing.Point(897, 401);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Padding = new System.Windows.Forms.Padding(10);
            this.buttonAdminLogin.Size = new System.Drawing.Size(255, 74);
            this.buttonAdminLogin.TabIndex = 2;
            this.buttonAdminLogin.Text = "Admin Login";
            this.buttonAdminLogin.UseVisualStyleBackColor = false;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(712, 661);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BillingPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.labelBSC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillingPOS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBSC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.Button buttonAdminLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

