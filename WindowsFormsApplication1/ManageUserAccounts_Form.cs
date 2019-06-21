using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EARS
{
    public partial class ManageUserAccounts_Form : Form
    {
        DataTable table;
        List<Faculty> facList;
        int currentUser;
        public ManageUserAccounts_Form(ref List<Faculty> people, int loggedIn)
        {
            InitializeComponent();
            facList = people;
            currentUser = loggedIn;
        }
        //Menu Strip on click listener to go to the Search Applicant Form
        private void searchApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            this.Visible = false;
            Search_Form searchForm = new Search_Form();
            searchForm.ShowDialog(this);
            this.Visible = true;
            this.Close();*/
        }
        //Menu Strip on click listener to go to the Account Settings Form
        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            AccountSettings_Form accountForm = new AccountSettings_Form(currentUser, false,ref facList, currentUser);
            accountForm.ShowDialog(this);
            this.Visible = true;
            this.Close();
        }

        private void ManageUserAccounts_Form_Load(object sender, EventArgs e)
        {
            
            string[] names = new string[facList.Count];
            table = new DataTable();
            DataRow row;
            DataColumn col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "item";
            table.Columns.Add(col);
            for (int i=0; i < names.Length;i++)
            {
                row = table.NewRow();
                row["item"]= facList.ElementAt(i).getFirstName() + " " + facList.ElementAt(i).getLastName();
                table.Rows.Add(row);
            }

            DataView view = new DataView(table);
            GridView.DataSource = view;
            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this.Visible = false;

                AccountSettings_Form accountForm = new AccountSettings_Form(e.RowIndex, true, ref facList, currentUser);
                accountForm.ShowDialog(this);
                this.Visible = true;
                //closes the current window
                this.Close();
            }
            
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
