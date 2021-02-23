using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Coursework
{
     public static class CSVFile
    {
        public static List<User> users;
        public static List<Location> locations;
        public static List<Contact> contacts;
        public static List<Visit> visits;


        public static string userPath = @"./users.csv";
        // public static string userPath = @"C:\Users\Patrycja\Desktop\users.csv";
        public static string locationsPath = @"./locations.csv";
        public static string contactPath = @"./contact.csv";
        public static string visitPath = @"./visit.csv";
        //public static string locationsPath = @"C:\Users\Patrycja\Desktop\locations.csv";
        //public static string contactPath = @"C:\Users\Patrycja\Desktop\contact.csv";
        //public static string visitPath = @"C:\Users\Patrycja\Desktop\visit.csv";


        static CSVFile()
        {
            //create lists in constructor
            users = new List<User>();
            locations = new List<Location>();
            contacts = new List<Contact>();
            visits = new List<Visit>();
        }

        //create write methods which will add to CSV files
        public static void writeToUserFile(User u)
        {
            string userData = u.Name + "," + u.UserID + "," + u.PhoneNumber + Environment.NewLine; //new line
            File.AppendAllText(userPath, userData);
        }

        public static void writeToLocationsFile(Location l)
        {
            string locationData = l.LocationName + Environment.NewLine;
            File.AppendAllText(locationsPath, locationData);
        }

        public static void writeToContactFile(Contact c)
        {
            string contactData = c.User1 + "," + c.User2 + "," + c.DateAndTime + Environment.NewLine;
            File.AppendAllText(contactPath, contactData);
        }

        public static void writeToVisitFile(Visit v)
        {
            string visitData = v.User + "," + v.Location + "," + v.DateAndTime + Environment.NewLine;
            File.AppendAllText(visitPath, visitData);
        }

        public static void loadFile()
        {
            //open users file
            StreamReader reader1 = new StreamReader(File.OpenRead(CSVFile.userPath));
            String header = reader1.ReadLine();

            while (!reader1.EndOfStream)
            {
                String line = reader1.ReadLine();
                //split by comma
                var values = line.Split(',');

                User user = new User();
                user.Name = values[0];
                user.UserID = values[1];
                user.PhoneNumber = values[2];
                //add to list
                users.Add(user);
            }

            //open locations file
            StreamReader reader2 = new StreamReader(File.OpenRead(CSVFile.locationsPath));
            String header2 = reader2.ReadLine();

            while (!reader2.EndOfStream)
            {
                String line = reader2.ReadLine();
                //split by comma
                var values = line.Split(',');

                Location location = new Location();
                location.LocationName = values[0];
                //add to list
                locations.Add(location);
            }
        }

        public static void loadVisits()
        {
            StreamReader reader4 = new StreamReader(File.OpenRead(visitPath));
            String header4 = reader4.ReadLine();

            while (!reader4.EndOfStream)
            {
                String line = reader4.ReadLine();
                var values = line.Split(',');

                Visit visit = new Visit();

                User user = new User();
                user.Name = values[0];
                user.UserID = values[1];
                user.PhoneNumber = values[2];

                Location location = new Location();
                location.LocationName = values[3];

                visit.User = user;
                visit.Location = location;

                visit.DateAndTime = DateTime.Parse(values[4]);

                //add to visit list
                visits.Add(visit);

            }
        }

        public static void loadContacts()
        {
            StreamReader reader3 = new StreamReader(File.OpenRead(contactPath));
            String header3 = reader3.ReadLine();

            while (!reader3.EndOfStream)
            {
                String line = reader3.ReadLine();
                var values = line.Split(',');

                Contact contact = new Contact();

                User user1 = new User();
                user1.Name = values[0];
                user1.UserID = values[1];
                user1.PhoneNumber = values[2];

                User user2 = new User();
                user2.Name = values[3];
                user2.UserID = values[4];
                user2.PhoneNumber = values[5];

                contact.User1 = user1;
                contact.User2 = user2;
                contact.DateAndTime = DateTime.Parse(values[6]);

                //add to contact list
                contacts.Add(contact);

            }
        }       
        public static IEnumerable<Contact> contactQuery(User filteredContact, DateTime filteredDate)
            {
                //search for specified user contacts after a specified date/time using LINQ
                var query = from contact in contacts
                            where (contact.User1.UserID == filteredContact.UserID || contact.User2.UserID == filteredContact.UserID) && (contact.DateAndTime > filteredDate)
                            select contact;

                return query;
            }

        public static IEnumerable<User> visitQuery(Location filteredlocation, DateTime filteredDate1, DateTime filteredDate2)
        {
            //search for users who visited a specified location between two specified dates/times using LINQ
            var query = from visit in visits
                       where ((visit.Location.LocationName.Equals(filteredlocation.LocationName)) && ((visit.DateAndTime > filteredDate1) && (visit.DateAndTime < filteredDate2)))
                        select visit.User;

           return query;
        }
    }

}


