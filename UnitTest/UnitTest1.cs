using Coursework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            //create instance and variable
            User user = new User();
            user.UserID = Guid.NewGuid().ToString("n");
            user.PhoneNumber = "07886547830";
            user.Name = "Rebecca";

            Location location = new Location();
            location.LocationName = "Grand Canyon";

            //act
            //write user to file
            CSVFile.writeToUserFile(user);
            CSVFile.writeToLocationsFile(location);


            //assert
            //read file
            CSVFile.loadFile();
            //get last line of users file
            if (CSVFile.users.Count > 0)
            {
                var item = CSVFile.users[CSVFile.users.Count - 1];

                //check if they're the same
                Assert.AreEqual(item.UserID, user.UserID);
                Assert.AreEqual(item.PhoneNumber, user.PhoneNumber);
                Assert.AreEqual(item.Name, user.Name);

            }

            //check last line of locations file
            if (CSVFile.locations.Count > 0)
            {
                var item = CSVFile.locations[CSVFile.locations.Count - 1];

                //check if they're the same
                Assert.AreEqual(item.LocationName, location.LocationName);

            }
        }
    }
}
