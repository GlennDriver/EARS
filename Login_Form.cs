using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EARS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Amanda Bakalarczyk\source\repos\EARS\EARS\EARS_DB.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "SELECT * FROM Login_Table WHERE username ='" + txtUsername.Text.Trim() + "' AND password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Main_Form main = new Main_Form();
                this.Hide();
                main.Show();
            }

            else
            {
                MessageBox.Show("Incorrect username or password");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
