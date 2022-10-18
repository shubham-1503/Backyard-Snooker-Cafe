namespace demo3
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelcrossbtn = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.btnLoginAd = new System.Windows.Forms.Button();
            this.lblDonthave = new System.Windows.Forms.Label();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.Piclock = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piclock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.labelcrossbtn);
            this.panel1.Controls.Add(this.lbladmin);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 124);
            this.panel1.TabIndex = 2;
            // 
            // labelcrossbtn
            // 
            this.labelcrossbtn.AutoSize = true;
            this.labelcrossbtn.BackColor = System.Drawing.Color.Navy;
            this.labelcrossbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelcrossbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcrossbtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelcrossbtn.Location = new System.Drawing.Point(1258, 3);
            this.labelcrossbtn.Name = "labelcrossbtn";
            this.labelcrossbtn.Size = new System.Drawing.Size(42, 46);
            this.labelcrossbtn.TabIndex = 10;
            this.labelcrossbtn.Text = "x";
            this.labelcrossbtn.Click += new System.EventHandler(this.labelcrossbtn_Click);
            // 
            // lbladmin
            // 
            this.lbladmin.BackColor = System.Drawing.Color.Navy;
            this.lbladmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbladmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.Color.White;
            this.lbladmin.Location = new System.Drawing.Point(0, 0);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(1308, 124);
            this.lbladmin.TabIndex = 0;
            this.lbladmin.Text = "Admin Login";
            this.lbladmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbladmin.Click += new System.EventHandler(this.lbladmin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(507, 235);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(371, 48);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.TextUsername_TextChanged);
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nextEnter);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AccessibleDescription = "";
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPassword.Location = new System.Drawing.Point(507, 333);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(371, 48);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nextEnter);
            // 
            // btnLoginAd
            // 
            this.btnLoginAd.BackColor = System.Drawing.Color.Green;
            this.btnLoginAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAd.ForeColor = System.Drawing.Color.White;
            this.btnLoginAd.Location = new System.Drawing.Point(751, 441);
            this.btnLoginAd.Name = "btnLoginAd";
            this.btnLoginAd.Padding = new System.Windows.Forms.Padding(10);
            this.btnLoginAd.Size = new System.Drawing.Size(255, 74);
            this.btnLoginAd.TabIndex = 8;
            this.btnLoginAd.TabStop = false;
            this.btnLoginAd.Text = "Login";
            this.btnLoginAd.UseVisualStyleBackColor = false;
            this.btnLoginAd.Click += new System.EventHandler(this.btnLoginAd_Click);
            // 
            // lblDonthave
            // 
            this.lblDonthave.AutoSize = true;
            this.lblDonthave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonthave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonthave.Location = new System.Drawing.Point(517, 561);
            this.lblDonthave.Name = "lblDonthave";
            this.lblDonthave.Size = new System.Drawing.Size(285, 28);
            this.lblDonthave.TabIndex = 9;
            this.lblDonthave.Text = "Don\'t have an account ?";
            // 
            // PicUser
            // 
            this.PicUser.Image = ((System.Drawing.Image)(resources.GetObject("PicUser.Image")));
            this.PicUser.Location = new System.Drawing.Point(448, 235);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(50, 48);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 7;
            this.PicUser.TabStop = false;
            // 
            // Piclock
            // 
            this.Piclock.Image = ((System.Drawing.Image)(resources.GetObject("Piclock.Image")));
            this.Piclock.Location = new System.Drawing.Point(448, 333);
            this.Piclock.Name = "Piclock";
            this.Piclock.Size = new System.Drawing.Size(50, 48);
            this.Piclock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piclock.TabIndex = 4;
            this.Piclock.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(567, 599);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(169, 28);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Register Now";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Green;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(354, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(10);
            this.btnClear.Size = new System.Drawing.Size(255, 74);
            this.btnClear.TabIndex = 11;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1308, 696);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblDonthave);
            this.Controls.Add(this.btnLoginAd);
            this.Controls.Add(this.PicUser);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Piclock);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nextEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piclock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.PictureBox Piclock;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.Button btnLoginAd;
        private System.Windows.Forms.Label lblDonthave;
        private System.Windows.Forms.Label labelcrossbtn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnClear;
    }
}