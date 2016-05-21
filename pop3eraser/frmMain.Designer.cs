namespace Pop3Eraser
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtLogGeneral = new System.Windows.Forms.TextBox();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.tabLogs = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPagePOP3 = new System.Windows.Forms.TabPage();
            this.txtLogPop3 = new System.Windows.Forms.TextBox();
            this.gbServerData = new System.Windows.Forms.GroupBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.cmbAuthMethod = new System.Windows.Forms.ComboBox();
            this.lblAuthMethod = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetInputFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTest = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.gbOutput.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPagePOP3.SuspendLayout();
            this.gbServerData.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.Location = new System.Drawing.Point(217, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete All Emails";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 22);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "*Address:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(62, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "*Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(85, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(40, 47);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 10;
            this.lblPort.Text = "Port:";
            // 
            // txtLogGeneral
            // 
            this.txtLogGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogGeneral.Location = new System.Drawing.Point(3, 3);
            this.txtLogGeneral.Multiline = true;
            this.txtLogGeneral.Name = "txtLogGeneral";
            this.txtLogGeneral.ReadOnly = true;
            this.txtLogGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogGeneral.Size = new System.Drawing.Size(598, 210);
            this.txtLogGeneral.TabIndex = 11;
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(75, 45);
            this.nPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(85, 20);
            this.nPort.TabIndex = 2;
            this.nPort.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.tabLogs);
            this.gbOutput.Location = new System.Drawing.Point(12, 145);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(618, 261);
            this.gbOutput.TabIndex = 13;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Logs";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.tabPageGeneral);
            this.tabLogs.Controls.Add(this.tabPagePOP3);
            this.tabLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLogs.Location = new System.Drawing.Point(3, 16);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.SelectedIndex = 0;
            this.tabLogs.Size = new System.Drawing.Size(612, 242);
            this.tabLogs.TabIndex = 12;
            this.tabLogs.SelectedIndexChanged += new System.EventHandler(this.tabLogs_SelectedIndexChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.txtLogGeneral);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(604, 216);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPagePOP3
            // 
            this.tabPagePOP3.Controls.Add(this.txtLogPop3);
            this.tabPagePOP3.Location = new System.Drawing.Point(4, 22);
            this.tabPagePOP3.Name = "tabPagePOP3";
            this.tabPagePOP3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePOP3.Size = new System.Drawing.Size(604, 216);
            this.tabPagePOP3.TabIndex = 1;
            this.tabPagePOP3.Text = "POP3";
            this.tabPagePOP3.UseVisualStyleBackColor = true;
            // 
            // txtLogPop3
            // 
            this.txtLogPop3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogPop3.Location = new System.Drawing.Point(3, 3);
            this.txtLogPop3.Multiline = true;
            this.txtLogPop3.Name = "txtLogPop3";
            this.txtLogPop3.ReadOnly = true;
            this.txtLogPop3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogPop3.Size = new System.Drawing.Size(598, 210);
            this.txtLogPop3.TabIndex = 12;
            // 
            // gbServerData
            // 
            this.gbServerData.Controls.Add(this.chkSSL);
            this.gbServerData.Controls.Add(this.txtAddress);
            this.gbServerData.Controls.Add(this.nPort);
            this.gbServerData.Controls.Add(this.lblAddress);
            this.gbServerData.Controls.Add(this.lblPort);
            this.gbServerData.Location = new System.Drawing.Point(12, 27);
            this.gbServerData.Name = "gbServerData";
            this.gbServerData.Size = new System.Drawing.Size(306, 75);
            this.gbServerData.TabIndex = 14;
            this.gbServerData.TabStop = false;
            this.gbServerData.Text = "POP3 Server";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(177, 48);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(68, 17);
            this.chkSSL.TabIndex = 3;
            this.chkSSL.Text = "Use SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            this.chkSSL.CheckedChanged += new System.EventHandler(this.chkSSL_CheckedChanged);
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.cmbAuthMethod);
            this.gbAccount.Controls.Add(this.lblAuthMethod);
            this.gbAccount.Controls.Add(this.lblPassword);
            this.gbAccount.Controls.Add(this.txtPassword);
            this.gbAccount.Controls.Add(this.txtUsername);
            this.gbAccount.Controls.Add(this.lblUsername);
            this.gbAccount.Location = new System.Drawing.Point(324, 27);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(306, 112);
            this.gbAccount.TabIndex = 15;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account";
            // 
            // cmbAuthMethod
            // 
            this.cmbAuthMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthMethod.FormattingEnabled = true;
            this.cmbAuthMethod.Items.AddRange(new object[] {
            "Username & Password",
            "APOP",
            "Auto",
            "CramMd5"});
            this.cmbAuthMethod.Location = new System.Drawing.Point(85, 71);
            this.cmbAuthMethod.Name = "cmbAuthMethod";
            this.cmbAuthMethod.Size = new System.Drawing.Size(192, 21);
            this.cmbAuthMethod.TabIndex = 7;
            // 
            // lblAuthMethod
            // 
            this.lblAuthMethod.AutoSize = true;
            this.lblAuthMethod.Location = new System.Drawing.Point(6, 74);
            this.lblAuthMethod.Name = "lblAuthMethod";
            this.lblAuthMethod.Size = new System.Drawing.Size(73, 13);
            this.lblAuthMethod.TabIndex = 6;
            this.lblAuthMethod.Text = "Auth. method:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 412);
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(615, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 16;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(643, 24);
            this.mainMenu.TabIndex = 17;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetInputFieldsToolStripMenuItem,
            this.clearLogsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetInputFieldsToolStripMenuItem
            // 
            this.resetInputFieldsToolStripMenuItem.Name = "resetInputFieldsToolStripMenuItem";
            this.resetInputFieldsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.resetInputFieldsToolStripMenuItem.Text = "Reset Input Fields";
            this.resetInputFieldsToolStripMenuItem.Click += new System.EventHandler(this.resetInputFieldsToolStripMenuItem_Click);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTest.Location = new System.Drawing.Point(15, 109);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 30);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 444);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.gbServerData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "POP3 Email Eraser";
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            this.gbOutput.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPagePOP3.ResumeLayout(false);
            this.tabPagePOP3.PerformLayout();
            this.gbServerData.ResumeLayout(false);
            this.gbServerData.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtLogGeneral;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.GroupBox gbServerData;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.ComboBox cmbAuthMethod;
        private System.Windows.Forms.Label lblAuthMethod;
        private System.Windows.Forms.TabControl tabLogs;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPagePOP3;
        private System.Windows.Forms.TextBox txtLogPop3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetInputFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

