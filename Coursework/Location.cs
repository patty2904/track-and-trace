using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Location
    {
        private string locationName;

        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }

        //constructor
        public Location()
        {

        }

        public override string ToString()
        {
            return $"{LocationName}";
        }
    }
}
