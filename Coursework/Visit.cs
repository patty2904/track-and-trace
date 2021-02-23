using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Visit : Event
    {
        private User user;
        private Location location;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }


        public Visit()
        { 
        }
    }
}
