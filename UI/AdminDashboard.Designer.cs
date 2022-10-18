namespace demo3
{
    partial class AdminDashboard
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
            this.lblAdminDashbrd = new System.Windows.Forms.Label();
            this.labelcrossbtn = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnMenuCard = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnItemAnalysis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblAdminDashbrd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 124);
            this.panel1.TabIndex = 0;
            // 
            // lblAdminDashbrd
            // 
            this.lblAdminDashbrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminDashbrd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashbrd.ForeColor = System.Drawing.Color.White;
            this.lblAdminDashbrd.Location = new System.Drawing.Point(0, 0);
            this.lblAdminDashbrd.Name = "lblAdminDashbrd";
            this.lblAdminDashbrd.Size = new System.Drawing.Size(1308, 124);
            this.lblAdminDashbrd.TabIndex = 1;
            this.lblAdminDashbrd.Text = "Admin Dashboard";
            this.lblAdminDashbrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelcrossbtn
            // 
            this.labelcrossbtn.AutoSize = true;
            this.labelcrossbtn.BackColor = System.Drawing.Color.Navy;
            this.labelcrossbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelcrossbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcrossbtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelcrossbtn.Location = new System.Drawing.Point(1253, 0);
            this.labelcrossbtn.Name = "labelcrossbtn";
            this.labelcrossbtn.Size = new System.Drawing.Size(41, 46);
            this.labelcrossbtn.TabIndex = 1;
            this.labelcrossbtn.Text = "x";
            this.labelcrossbtn.Click += new System.EventHandler(this.labelcrossbtn_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.Green;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(257, 207);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(282, 131);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnMenuCard
            // 
            this.btnMenuCard.BackColor = System.Drawing.Color.Green;
            this.btnMenuCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCard.ForeColor = System.Drawing.Color.White;
            this.btnMenuCard.Location = new System.Drawing.Point(257, 476);
            this.btnMenuCard.Name = "btnMenuCard";
            this.btnMenuCard.Size = new System.Drawing.Size(282, 131);
            this.btnMenuCard.TabIndex = 3;
            this.btnMenuCard.Text = "Menu Card";
            this.btnMenuCard.UseVisualStyleBackColor = false;
            this.btnMenuCard.Click += new System.EventHandler(this.btnMenuCard_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.Green;
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransactions.Location = new System.Drawing.Point(786, 207);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(282, 131);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Analysis";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnItemAnalysis
            // 
            this.btnItemAnalysis.BackColor = System.Drawing.Color.Green;
            this.btnItemAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemAnalysis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemAnalysis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnItemAnalysis.Location = new System.Drawing.Point(786, 476);
            this.btnItemAnalysis.Name = "btnItemAnalysis";
            this.btnItemAnalysis.Size = new System.Drawing.Size(282, 131);
            this.btnItemAnalysis.TabIndex = 5;
            this.btnItemAnalysis.Text = "Item Analysis";
            this.btnItemAnalysis.UseVisualStyleBackColor = false;
            this.btnItemAnalysis.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1308, 696);
            this.Controls.Add(this.btnItemAnalysis);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnMenuCard);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.labelcrossbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminDashbrd;
        private System.Windows.Forms.Label labelcrossbtn;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnMenuCard;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnItemAnalysis;
    }
}