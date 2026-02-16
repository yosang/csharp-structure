using Models;

namespace Services
{
    public class UserService
    {
        // This delegate separates responsibility (like logging or notifying after creating a user)
        public delegate void NotifyUser(User user);

        // Event
        public event NotifyUser? Notify;

        // Rises an event
        public void CreateUser(User user)
        {
            Console.WriteLine("Saving user to the database...");
            if (Notify != null)
            {
                Notify(user);
            }
        }

    }
}