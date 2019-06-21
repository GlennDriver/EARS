using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EARS
{
    public partial class Faculty : Person
    {
        private string username;
        private string password;
        private int accountType;

        public Faculty(Person person, string username, string password, int accountType) 
            : base(person.getFirstName(), person.getLastName(), person.getEmail(), person.getPhoneNumber())
        {
            this.username = username;
            this.password = password;
            this.accountType = accountType;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
        public void setPassword(string pass)
        {
            password = pass;
        }

        //account type must be 1, 2, or 3
        //1 = faculty, 2 = committee member, 3 = committee chair
        public void  setAccountType(int value)
        {

                if (value > 0 && value <= 3)
                {
                    accountType = value;
                }
                else
                {
                    throw new Exception("Account type cannot be set to this value");
                }
            
        }
        public int getAccountType()
        {
            return accountType;
        }
        public override string ToString()
        {
            return base.ToString()+" "+username+" "+password+" "+accountType;
        }
    }
}
