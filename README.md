# track-and-trace

A prototype for a track-and-trace system that will allow users to keep track of individuals with whom they have come into contact with and places that they have been.

TrackTrace will have a number of users, users will have a unique ID and phone number. The system will record events that are associated with each user. Events fall into two types

A contact occurs when two users have come into contact. Each contact should record, the date and time of the contact and the two individuals involved.
A visit occurs when a user checks in at a particular location Each visit should record  the user, the date time of the visit and the location.
The system should also allow the creation of locations (shops, cafes etc).

The presentation layer created will allow testing of the business objects, via a WPF based interface. Buttons allow the following functionality:

1.     Add a new individual.

2.     Add a new location

3.     Record the visit of an individual to a location

4.     Record a contact between two individuals

5.     Generate a list of all the telephone numbers of all individuals who have been contacts of a specified individual after a specified date and time

6.     Generate a list of telephone numbers of all individuals who visited a location between two dates and times

The data layer allows the list of events, users and locations to be written to, and read from a .CSV file.
