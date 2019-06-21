using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EARS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Faculty[] fac = new Faculty[4];
            fac[0]= new Faculty(new Person("Glenn", "Driver", "glenn.driver024@hotmail.com", "(705)975-1999"), "gdriver", "pass", 2);
            fac[1] = new Faculty(new Person("Amanda", "Bakalarczyk", "abakalar@algomau.ca", "(705)987-1522"), "abakalar", "pass", 2);
            fac[2] = new Faculty(new Person("Jaye", "?", "Jaye@algomau.ca", "(705)529-7401"), "jaye", "pass", 2);
            fac[3] = new Faculty(new Person("admin", "admin", "admin@admin.com", "(705)999-9999"), "admin", "admin", 3);
            //string filepath = Environment.CurrentDirectory;
            //MessageBox.Show(filepath);
            FileStream fs = new FileStream(@"../../../tf.dat",FileMode.OpenOrCreate);
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                for(int i=0; i < 4; i++)
                {
                    w.Write(fac[i].ToString()+"\n");
                }
            }
          //  for(int i = 0; i < fac.Length; i++)
          //  {
              //  MessageBox.Show(fac[i].ToString());
              //  w.WriteLine(fac[i]);
                /* w.Write(fac[i].getEmail());
                w.Write(fac[i].getFirstName());
                w.Write(fac[i].getLastName());
                w.Write(fac[i].getPassword());
                w.Write(fac[i].getPhoneNumber());
                w.Write(fac[i].getUsername());
                w.Write(fac[i].getAccountType()+"");*/
            //}
            //w.Close();
            MessageBox.Show("Writing complete");
        }
    }
}
