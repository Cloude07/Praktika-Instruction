namespace Instruction
{
    partial class ConectionForm
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
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.lblServers = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.cbIPServer = new System.Windows.Forms.ComboBox();
            this.btConect = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.statusConect.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusConect
            // 
            this.statusConect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusConect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 269);
            this.statusConect.Name = "statusConect";
            this.statusConect.Size = new System.Drawing.Size(425, 22);
            this.statusConect.SizingGrip = false;
            this.statusConect.TabIndex = 28;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(12, 17);
            this.tsslStatus.Text = "-";
            // 
            // tbUserID
            // 
            this.tbUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserID.Location = new System.Drawing.Point(167, 109);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(169, 20);
            this.tbUserID.TabIndex = 27;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(12, 189);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(148, 13);
            this.lblDataSource.TabIndex = 26;
            this.lblDataSource.Text = "Список источников данных:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 152);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(122, 13);
            this.lbPassword.TabIndex = 25;
            this.lbPassword.Text = "Пароль пользователя:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(13, 109);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(128, 13);
            this.lblUsers.TabIndex = 24;
            this.lblUsers.Text = "Пользователь сервера:";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(12, 68);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(105, 13);
            this.lbServer.TabIndex = 23;
            this.lbServer.Text = "Название сервера:";
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Location = new System.Drawing.Point(12, 35);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(86, 13);
            this.lblServers.TabIndex = 22;
            this.lblServers.Text = "Адрес сервера:";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(167, 150);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(169, 20);
            this.tbPassword.TabIndex = 21;
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInitialCatalog.Enabled = false;
            this.cbInitialCatalog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(167, 186);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(169, 21);
            this.cbInitialCatalog.TabIndex = 20;
            // 
            // cbDataSource
            // 
            this.cbDataSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDataSource.Enabled = false;
            this.cbDataSource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(167, 68);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(169, 21);
            this.cbDataSource.TabIndex = 19;
            // 
            // cbIPServer
            // 
            this.cbIPServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIPServer.Enabled = false;
            this.cbIPServer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbIPServer.FormattingEnabled = true;
            this.cbIPServer.Location = new System.Drawing.Point(167, 35);
            this.cbIPServer.Name = "cbIPServer";
            this.cbIPServer.Size = new System.Drawing.Size(169, 21);
            this.cbIPServer.TabIndex = 18;
            // 
            // btConect
            // 
            this.btConect.Location = new System.Drawing.Point(222, 225);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(100, 32);
            this.btConect.TabIndex = 16;
            this.btConect.Text = "Подключиться";
            this.btConect.UseVisualStyleBackColor = true;
            this.btConect.Click += new System.EventHandler(this.btConect_Click);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(55, 225);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(105, 32);
            this.btCheck.TabIndex = 15;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // ConectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 291);
            this.Controls.Add(this.statusConect);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.cbDataSource);
            this.Controls.Add(this.cbIPServer);
            this.Controls.Add(this.btConect);
            this.Controls.Add(this.btCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ConectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к серверу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConectionForm_Load);
            this.Shown += new System.EventHandler(this.ConectionForm_Shown);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusConect;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.ComboBox cbIPServer;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.Button btCheck;
    }
}