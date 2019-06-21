using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EARS
{
    public partial class Login_Form : Form
    {
        //list that holds all faculty that is passed from form to form
        List<Faculty> facList = new List<Faculty>();
        public Login_Form()
        {
            InitializeComponent();
        }
        //When the login button is clicked, validate the username and password, then either: Display an error, or create the next form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            if (validUser(user, pass))
            {
                Main_Form main = new Main_Form(facList, getUserIndex(user));
                this.Hide();
                main.Show();
            }
            else
                MessageBox.Show("Invalid username or password");
            
        }
        //When the cancel button is clicked. Closes the window.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //When the page loads it reads all the users from the file and adds them to the list
        private void Login_Form_Load(object sender, EventArgs e)
        {
            //File stream, the file it looks for is 3 folders above its current one
            FileStream fs = new FileStream(@"../../../tf.dat", FileMode.OpenOrCreate);
            //number of users read in
            int numItems = 0;
            //a string that holds each line in the file, will be used to creat faculty objects
            string[] info = new string[9999];
            using (BinaryReader read = new BinaryReader(fs))
            {
               
                while (fs.Position != fs.Length)
                {
                    try
                    {
                        info[numItems] = read.ReadString() + "";
                        numItems++;
                    }
#pragma warning disable CS0168 // Variable is declared but never used because it is to tell when the file is ended
                    catch (EndOfStreamException ex)
#pragma warning restore CS0168 
                    {
                        break;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error reading in from file: "+ex.ToString());
                    }

                }
                   
                    
                
            }
            //Takes the strings and seprates them into a temporary array to be used to create the Faculty objects
            for (int i = 0; i < numItems; i++)
            {
                int infoPosition = 0;
                string[] tempinfo = new string[7];
                for (int j = 0; j < info[i].Length; j++)
                {
                    if (info[i][j] == ' ')
                    {
                        tempinfo[infoPosition] = info[i].Substring(0,j).Trim(' ');
                        info[i] = info[i].Substring(j);
                        j = 0;
                        infoPosition++;
                    }
                    if(j== info[i].Length-1)
                    {
                        tempinfo[6] = info[i];
                    }
                }
                //creation of the new Faculty object
                facList.Add(new Faculty(new Person(tempinfo[0], tempinfo[1], tempinfo[2], tempinfo[3]), tempinfo[4], tempinfo[5], int.Parse(tempinfo[6])));
            }
        }
        //takes in a password and username as a string, outputs a boolean stating if the username is valid, then if it is, makes sure the passowrd matches as well. 
        public bool validUser(string user, string pass)
        {
            for(int i = 0; i < facList.Count; i++)
            {
                if (facList.ElementAt(i).getUsername().Equals(user))
                {
                    if (facList.ElementAt(i).getPassword().Equals(pass))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Takes in a string that is a users username, outputs the index in the List that they are held
        private int getUserIndex(string username)
        {
            for(int i = 0; i < facList.Count; i++)
            {
                if (username.Equals(facList.ElementAt(i).getUsername()))//Checks if the username given is the equal to the username in the Faculty object
                {
                    return i;//returns the index
                }
            }
            //returns -1, although this code will never be reached as this method is only called after the username is validated
            return -1;
        }
    }
}
