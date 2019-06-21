using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EARS
{
    public partial class AccountSettings_Form : Form
    {

        List<Faculty> facList;
        //the current account that is logged in
        Faculty user;
        int currentUser;
        //a boolean check to see if the user is editing their own account information or is an admin doing it
        bool manageAcc;
        //constructor, takes the current logged in account
        public AccountSettings_Form(int recevingEdit, bool fromManageAcc, ref List<Faculty> allUsers, int loggediIn)//Faculty currentUser
        {
            facList = allUsers;
            manageAcc = fromManageAcc;
            //adds all components to the window
            InitializeComponent();
            user = allUsers.ElementAt(recevingEdit);
            currentUser = loggediIn;
        }

        //clicking on the "search" button on the top strip
        private void searchApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            //makes the current window invisible and creates the search form
            /*this.Visible = false;
            Search_Form searchForm = new Search_Form();
            searchForm.ShowDialog(this);
            this.Visible = true;
            //closes the current window
            this.Close();*/
        }

        private void manageUserAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //makes the current window invisible and creates the search form
/*             this.Visible = false;
             ManageUserAccounts_Form manageForm = new ManageUserAccounts_Form();
             manageForm.ShowDialog(this);
             this.Visible = true;
             //closes the current window
             this.Close();*/
        }
        //When the form loads, it populates the appropriate fields with the information in the passed account
        private void AccountSettings_Form_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = user.getUsername();
            PassBox.Text = user.getPassword();
            FirstNameBox.Text = user.getFirstName();
            LastNameBox.Text = user.getLastName();
            EmailBox.Text = user.getEmail();
            PhoneNumberBox.Text = user.getPhoneNumber();
            AccountPermissionsBox.Text = user.getAccountType()+"";
        }
        //When Save Changes is clicked
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            //a boolean flag so that the error message boxes are only displayed once.
            bool formats = checkFormats();

            user.setEmail(EmailBox.Text);
            user.setPassword(PassBox.Text);
            user.setPhoneNumber(PhoneNumberBox.Text);
            user.setFirstName(FirstNameBox.Text);
            user.setLastName(LastNameBox.Text);
            //if the user has the authourity to edit account types, change the account type, if not, display an error
            if (facList.ElementAt(currentUser).getAccountType() == 3)
            {
                user.setAccountType(int.Parse(AccountPermissionsBox.Text));
            }
            else
                MessageBox.Show("You do not have permission to change the Account type, changes to it will not be saved.");
            //file output system
            //Binary writer for encoding data  
            using (BinaryWriter w = new BinaryWriter(new FileStream(@"../../../tf.dat", FileMode.OpenOrCreate)))
            {
                //loop that writes information
                for (int i = 0; i < facList.Count; i++)
                {
                    w.Write(facList.ElementAt(i).ToString());
                }
                w.Close();
            }
            //if the user is an admin and the email and phone have correct formats, go back to the manage user accounts form
            if (manageAcc&& formats)
            {
                this.Visible = false;
                ManageUserAccounts_Form manageForm = new ManageUserAccounts_Form(ref facList, currentUser);
                manageForm.ShowDialog(this);
                this.Visible = true;
                //closes the current window
                this.Close();
            }
            //If the user is not an admin editing the account, and the phonenumber and email have correct formats, save and go back to the main menu
            if(!manageAcc&& formats)
            {
                this.Visible = false;
                Main_Form mainMenu = new Main_Form(facList, currentUser);
                mainMenu.ShowDialog(this);
                this.Close();
            }
            
        }
        private bool checkFormats()
        {
            if (!checkPhoneNumber())
            {
                MessageBox.Show("Wrong Format for Phone Number\nUse: (###)###-####");
                errorProvider1.SetError(PhoneNumberBox, "Wrong Format, use: (###)###-####");
                return false;
            }
            else if(!checkEmail())
            {
                MessageBox.Show("Wrong Format, needs an '@' and a .(domain)");
                errorProvider2.SetError(EmailBox, "Wrong format, needs an '@' and a .(domain)");
                return false;
            }
            return true;
        }
        //takes in the sender object, and the event that caused it
        //When the phone number is changed, check that it is in the proper format
        private bool checkPhoneNumber()
        {
            char[] phoneNum = PhoneNumberBox.Text.ToCharArray();
            for (int i = 0; i < phoneNum.Length; i++)
            {
                //checks for format validity. 
                //if the current character isn't a valid character, or: If any of the special characters aren't present: '(',')','-'
                if (isValid(phoneNum[i]) && (phoneNum[0] == '(') &&
                        (phoneNum[4] == ')') && (phoneNum[8] == '-')&&(phoneNum.Length==13))
                {
                    return true;
                }
            }

            return false;
        }
        //checks the email for formatting *@*.*, were * is any number of characters
        private bool checkEmail()
        {
            //two booleans for checking if each required special char exists
            bool hasAt = false;
            bool hasDot = false;
            for(int i=0; i < EmailBox.Text.Length; i++)
            {
                //once an @ is found, mark the flag
                if (EmailBox.Text[i] == '@')
                {
                    hasAt = true;
                }
                //if it has an @ and is followed by a '.' somewhere that isn't the last character, it is likely correct.
                // this is so we don't cover every custom domain
                if (hasAt&& EmailBox.Text[i] == '.'&&i!= EmailBox.Text.Length)
                {
                    hasDot = true;
                }
            }
            //if both flags are marked, it is most likely a correct format
            if(hasDot&&hasAt)
                return true;
            return false;
        }
        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Takes in a Char c, returns a boolean
        //checks to see if the character c is a valid character for a phone number (Is it a number, '(',')', or '-'?)
        private bool isValid(char c)
        {
            if (c <= '9' && c >= '0')
            {
                return true;
            }
            else if (c=='('||c==')'||c=='-')
            {
                return true;
            }
            return false;
        }
    }
}
