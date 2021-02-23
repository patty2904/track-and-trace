using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Coursework
{
    public class User
    {
        private string userID;
        private string phoneNumber;
        private string name;


        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        public User()
        {
        }

        public override string ToString()
        {
            return $"{Name},{UserID},{PhoneNumber}";
        }
    }
}
