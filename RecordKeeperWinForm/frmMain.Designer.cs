namespace RecordKeeperWinForm
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gRecordSummary = new System.Windows.Forms.DataGridView();
            this.gPartyList = new System.Windows.Forms.DataGridView();
            this.gPresidentList = new System.Windows.Forms.DataGridView();
            this.tblConnection = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNewPresident = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecordSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).BeginInit();
            this.tblConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.gRecordSummary, 0, 1);
            this.tblMain.Controls.Add(this.gPartyList, 1, 1);
            this.tblMain.Controls.Add(this.gPresidentList, 0, 2);
            this.tblMain.Controls.Add(this.tblConnection, 0, 0);
            this.tblMain.Controls.Add(this.btnNewPresident, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.53264F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.77546F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.Size = new System.Drawing.Size(656, 383);
            this.tblMain.TabIndex = 0;
            // 
            // gRecordSummary
            // 
            this.gRecordSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecordSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecordSummary.Location = new System.Drawing.Point(3, 51);
            this.gRecordSummary.Name = "gRecordSummary";
            this.gRecordSummary.RowTemplate.Height = 25;
            this.gRecordSummary.Size = new System.Drawing.Size(322, 154);
            this.gRecordSummary.TabIndex = 0;
            // 
            // gPartyList
            // 
            this.gPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPartyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPartyList.Location = new System.Drawing.Point(331, 51);
            this.gPartyList.Name = "gPartyList";
            this.gPartyList.RowTemplate.Height = 25;
            this.gPartyList.Size = new System.Drawing.Size(322, 154);
            this.gPartyList.TabIndex = 1;
            // 
            // gPresidentList
            // 
            this.gPresidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPresidentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPresidentList.Location = new System.Drawing.Point(3, 211);
            this.gPresidentList.Name = "gPresidentList";
            this.gPresidentList.RowTemplate.Height = 25;
            this.gPresidentList.Size = new System.Drawing.Size(322, 169);
            this.gPresidentList.TabIndex = 2;
            // 
            // tblConnection
            // 
            this.tblConnection.ColumnCount = 5;
            this.tblMain.SetColumnSpan(this.tblConnection, 2);
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.Controls.Add(this.label2, 1, 0);
            this.tblConnection.Controls.Add(this.label3, 2, 0);
            this.tblConnection.Controls.Add(this.label4, 3, 0);
            this.tblConnection.Controls.Add(this.label5, 4, 0);
            this.tblConnection.Controls.Add(this.txtServer, 0, 1);
            this.tblConnection.Controls.Add(this.label1, 0, 0);
            this.tblConnection.Controls.Add(this.txtDB, 1, 1);
            this.tblConnection.Controls.Add(this.txtUserName, 2, 1);
            this.tblConnection.Controls.Add(this.txtPassword, 3, 1);
            this.tblConnection.Controls.Add(this.btnConnect, 4, 1);
            this.tblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConnection.Location = new System.Drawing.Point(3, 3);
            this.tblConnection.Name = "tblConnection";
            this.tblConnection.RowCount = 2;
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblConnection.Size = new System.Drawing.Size(650, 42);
            this.tblConnection.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 4;
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(3, 17);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(124, 23);
            this.txtServer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtDB
            // 
            this.txtDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDB.Location = new System.Drawing.Point(133, 17);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(124, 23);
            this.txtDB.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(263, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(124, 23);
            this.txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(393, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(124, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(523, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 22);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnNewPresident
            // 
            this.btnNewPresident.AutoSize = true;
            this.btnNewPresident.Location = new System.Drawing.Point(331, 211);
            this.btnNewPresident.Name = "btnNewPresident";
            this.btnNewPresident.Size = new System.Drawing.Size(93, 25);
            this.btnNewPresident.TabIndex = 4;
            this.btnNewPresident.Text = "New President";
            this.btnNewPresident.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 383);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecordSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).EndInit();
            this.tblConnection.ResumeLayout(false);
            this.tblConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecordSummary;
        private DataGridView gPartyList;
        private DataGridView gPresidentList;
        private TableLayoutPanel tblConnection;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtServer;
        private Label label1;
        private TextBox txtDB;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnConnect;
        private Button btnNewPresident;
    }
}