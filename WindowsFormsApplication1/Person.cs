using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EARS
{
    public partial class Person
    {
        protected string firstName;
        protected string lastName;
        protected string email;
        protected string phoneNumber;

        public Person(string fName, string lName, string emailAddress, string phoneNum)
        {
            firstName = fName;
            lastName = lName;
            email = emailAddress;
            phoneNumber = phoneNum;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string fname)
        {
            firstName = fname;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setLastName(string lname)
        {
            lastName = lname;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail(string newEmail)
        {
            email = newEmail;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setPhoneNumber(string phone)
        {
            phoneNumber = phone;
        }
        public override string ToString()
        {
            return firstName + " " +lastName+" "+ email+" "+phoneNumber;
        }
    }
}
