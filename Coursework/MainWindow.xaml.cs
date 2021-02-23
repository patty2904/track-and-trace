using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Coursework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CSVFile.loadFile();

            //loop over lists with CSV file data so that data is 
            //automatically displayed in the text boxes when the program is run
            foreach (User u in CSVFile.users)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = u;
                lstUserList.Items.Add(item);
            }

            foreach (Location l in CSVFile.locations)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = l;
                lstLocationList.Items.Add(item);
            }

        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            //validate phone number
            //don't allow to add to csv/listbox if not valid
            if ((!(Regex.IsMatch(txtAddUserPhone.Text, @"^\d+$"))) || (txtAddUserPhone.Text.Length < 11 || txtAddUserPhone.Text.Length > 11) || !(txtAddUserPhone.Text.StartsWith("07")))
            {
                MessageBox.Show("Invalid phone number.");
            }
            else
            {
                User u = new User();
                ListBoxItem userName = new ListBoxItem();
                //add properties to instance of class
                u.Name = txtAddName.Text;
                //generate random ID (non-repetitive)
                u.UserID = Guid.NewGuid().ToString("n");
                u.PhoneNumber = txtAddUserPhone.Text;
                //add to listbox and to CSV file
                CSVFile.writeToUserFile(u);
                userName.Content = u;

            }

        }

        private void btnAddLocation_Click(object sender, RoutedEventArgs e)
        {
            Location l = new Location();
            ListBoxItem locationName = new ListBoxItem();
            //add properties to instance of class
            l.LocationName = txtAddLocation.Text;
            //add to listbox and to CSV file
            CSVFile.writeToLocationsFile(l);
            lstLocationList.Items.Add(locationName);
            locationName.Content = l;
        }

        private void btnRecordContact_Click(object sender, RoutedEventArgs e)
        {
            if (lstUserList.SelectedItems.Count < 2)
                return;
            //ask for date from a message box and store it
            string specifiedDateAndTime = Interaction.InputBox("Enter the date and time ", "Date and Time", "");
            var parsedDate = DateTime.Parse(specifiedDateAndTime);
            Contact c = new Contact();
            //add item selected by user from listbox to properties of instance
            c.User1 = ((User)((ListBoxItem)lstUserList.SelectedItems[0]).Content);
            c.User2 = ((User)((ListBoxItem)lstUserList.SelectedItems[1]).Content);
            c.DateAndTime = parsedDate;

            //add to CSV file 
            CSVFile.writeToContactFile(c);
            MessageBox.Show("Contact between the selected users has been recorded.");

        }

        private void btnRecordVisit_Click(object sender, RoutedEventArgs e)
        {
            
            //ask for date from a message box and store it
            string specifiedDateAndTime = Interaction.InputBox("Enter the date and time ", "Date and Time", "");
            var parsedDate = DateTime.Parse(specifiedDateAndTime);
            Visit v = new Visit();
            //add item selected by user from listbox to properties of instance
            v.User = ((User)((ListBoxItem)lstUserList.SelectedItems[0]).Content);
            v.Location = ((Location)((ListBoxItem)lstLocationList.SelectedItems[0]).Content);
            v.DateAndTime = parsedDate;
            //add to CSV file 
            CSVFile.writeToVisitFile(v);
            MessageBox.Show("Visit of the selected person and location has been recorded.");
        }

        private void btnContactPhone_Click(object sender, RoutedEventArgs e)
        {
            CSVFile.loadContacts();
            //make sure an error isnt thrown is something is chosen > 1 time
            if (lstUserList.SelectedItems.Count == 0)
                return;

            //allow user the select the contact from the listbox
            var search = ((User)((ListBoxItem)lstUserList.SelectedItems[0]).Content);

            //ask for date
            string specifiedDateAndTime = Interaction.InputBox("Enter the date and time ", "Date and Time", "");
            var parsedDate = DateTime.Parse(specifiedDateAndTime);

            //call method doing the query 
            var results = CSVFile.contactQuery(search, parsedDate);

            if (results != null)
                foreach (Contact c in results)
                {
                    if (c.User1.UserID == search.UserID)
                    {
                        //write the phone number of user2 to listbox
                        lstContactPhone.Items.Add(c.User2.PhoneNumber);
                    }
                    else
                    {
                        //write phone number of user1 to listbox  
                        lstContactPhone.Items.Add(c.User1.PhoneNumber);
                    }
                }
        }

        private void btnVisitPhone_Click(object sender, RoutedEventArgs e)
        {
            CSVFile.loadVisits();
            if (lstLocationList.SelectedItems.Count == 0)
                return;

            var search = ((Location)((ListBoxItem)lstLocationList.SelectedItems[0]).Content);

            //ask for two dates
            string specifiedDateAndTime1 = Interaction.InputBox("Enter the first date and time ", "Date and Time", "");
            var parsedDate1 = DateTime.Parse(specifiedDateAndTime1);

            string specifiedDateAndTime2 = Interaction.InputBox("Enter the first date and time ", "Date and Time", "");
            var parsedDate2 = DateTime.Parse(specifiedDateAndTime2);

            //call method which performs query
            var results = CSVFile.visitQuery(search, parsedDate1, parsedDate2);

            //loop through users in results var created above
            foreach (User user in results)
            {
                //add appropriate number to listbox
                lstVisitPhone.Items.Add(user.PhoneNumber);
            }
        }
    }
}