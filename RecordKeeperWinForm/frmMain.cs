using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordKeeperBizObjects;
using CPUFramework;

namespace RecordKeeperWinForm
{
    public partial class frmMain : Form
    {
        int numtriestoconnect = 0;
        public frmMain()
        {
            InitializeComponent();
            btnConnect.Click += BtnConnect_Click;
            gPresidentList.CellDoubleClick += GPresidentList_CellDoubleClick;
            btnNewPresident.Click += BtnNewPresident_Click;
            //"Server=tcp:nsilberstein.database.windows.net,1433;Initial Catalog = RecordKeeperDB; Persist Security Info=False;User ID = nsilbersteinadmin; Password=CPU123!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            txtServer.Text = "nsilberstein.database.windows.net,1433";
            txtDB.Text = "RecordKeeperDB";
            txtUserName.Text = "nsilbersteinadmin";
            txtPassword.Text = "CPU123!@#";
        }

    

        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataUtility.SetConnectionString(txtServer.Text, txtDB.Text, txtUserName.Text, txtPassword.Text);
                numtriestoconnect = 0;
                BindForm();
            }
            catch (SqlException ex) when (ex.Message.StartsWith("Login failed for user"))
            {
                numtriestoconnect++;
                if (numtriestoconnect < 3)
                {
                    MessageBox.Show("Invalid username or password. You have" + (3 - numtriestoconnect).ToString() + "left to try.");
                }
                else
                {
                    MessageBox.Show("Bye bye");
                    Application.Exit();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect. Fix the server and or database information and try again." + Environment.NewLine + ex.Message, "RecordKeeper");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private void BindForm()
        {
            gRecordSummary.DataSource = DataService.GetUSGovRecordSummary();
            gPartyList.DataSource = DataService.GetPartyList();
            gPresidentList.DataSource = DataService.GetPresidentList();

            this.FormatGrid(gRecordSummary);
            this.FormatGrid(gPartyList, "PartyId");
            this.FormatGrid(gPresidentList, "PresidentId");
        }

        private void CreateNewPresident()
        {
            frmPresidentDetail f = new frmPresidentDetail();
            f.ShowForm(0);
        }

        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridobj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridobj.RowHeadersWidth = 25;
            gridobj.AllowUserToAddRows = false;
            if (PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }

        private void GPresidentList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gPresidentList.Rows[e.RowIndex].Cells["PresidentId"].Value;
            frmPresidentDetail f = new frmPresidentDetail();
            f.ShowForm(id);
        }
        private void BtnNewPresident_Click(object? sender, EventArgs e)
        {
            CreateNewPresident();
        }
    }
}
