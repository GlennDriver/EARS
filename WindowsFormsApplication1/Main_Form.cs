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
    public partial class Main_Form : Form
    {
        List<Faculty> facList;
        int currentUser;
        public Main_Form(List<Faculty> facList, int currentUserIndex)
        {
            currentUser = currentUserIndex;
            InitializeComponent();
            this.facList = facList;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        // On click listener for searching 
        private void searchApplicants_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Search_Form searchForm = new Search_Form();
            //searchForm.ShowDialog(this);
            this.Visible = true;
            this.Close();
        
        }

        // On click listener for managing user accounts
        private void manageUserAccounts_Click(object sender, EventArgs e)
        {
            if (facList.ElementAt(currentUser).getAccountType() == 3)
            {
                this.Visible = false;
                ManageUserAccounts_Form manageForm = new ManageUserAccounts_Form(ref facList, currentUser);
                manageForm.ShowDialog(this);
                this.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You do not have permission to edit other user accounts.\nIf you think this is an error please contact your Admin.");
            }
        }

        // On click listener for managing account settings
        private void accountSettings_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AccountSettings_Form accountForm = new AccountSettings_Form(currentUser, false,ref facList, currentUser);
            accountForm.ShowDialog(this);
            this.Visible = true;
            this.Close();

        }
    }
}
