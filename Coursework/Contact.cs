namespace Coursework
{
    public class Contact : Event
    {
        private User user1;
        private User user2;

        public User User1
        {
            get { return user1; }
            set { user1 = value; }
        }

        public User User2
        {
            get { return user2; }
            set { user2 = value; }
        }

        public Contact()
        {

        }
    }
}
