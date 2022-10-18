namespace demo3
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.panelUserLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelcrossbtn = new System.Windows.Forms.Label();
            this.btnLoginUser = new System.Windows.Forms.Button();
            this.panelUserLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserLogin
            // 
            this.panelUserLogin.BackColor = System.Drawing.Color.Navy;
            this.panelUserLogin.Controls.Add(this.label1);
            this.panelUserLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserLogin.Location = new System.Drawing.Point(0, 0);
            this.panelUserLogin.Name = "panelUserLogin";
            this.panelUserLogin.Size = new System.Drawing.Size(1308, 124);
            this.panelUserLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1308, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(507, 235);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(371, 48);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nextEnter);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(507, 333);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(371, 48);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nextEnter);
            // 
            // PicUser
            // 
            this.PicUser.Image = ((System.Drawing.Image)(resources.GetObject("PicUser.Image")));
            this.PicUser.Location = new System.Drawing.Point(448, 235);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(50, 48);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 3;
            this.PicUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelcrossbtn
            // 
            this.labelcrossbtn.AutoSize = true;
            this.labelcrossbtn.BackColor = System.Drawing.Color.Navy;
            this.labelcrossbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelcrossbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcrossbtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelcrossbtn.Location = new System.Drawing.Point(1253, 0);
            this.labelcrossbtn.Name = "labelcrossbtn";
            this.labelcrossbtn.Size = new System.Drawing.Size(42, 46);
            this.labelcrossbtn.TabIndex = 5;
            this.labelcrossbtn.Text = "x";
            this.labelcrossbtn.Click += new System.EventHandler(this.labelcrossbtn_Click);
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.BackColor = System.Drawing.Color.Green;
            this.btnLoginUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginUser.Location = new System.Drawing.Point(530, 435);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Padding = new System.Windows.Forms.Padding(10);
            this.btnLoginUser.Size = new System.Drawing.Size(255, 74);
            this.btnLoginUser.TabIndex = 6;
            this.btnLoginUser.TabStop = false;
            this.btnLoginUser.Text = "Login";
            this.btnLoginUser.UseVisualStyleBackColor = false;
            this.btnLoginUser.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1308, 696);
            this.Controls.Add(this.btnLoginUser);
            this.Controls.Add(this.labelcrossbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panelUserLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.panelUserLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelcrossbtn;
        private System.Windows.Forms.Button btnLoginUser;
    }
}