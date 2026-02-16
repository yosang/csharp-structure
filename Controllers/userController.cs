using Models;
using Services;

namespace Controllers
{
    public class UserController
    {
        // Property with automatic readonly implementation
        // Meaning it can be read from the outside, but only set from the inside (constructor in this case)
        public UserService UserService { get; }

        // Constructor creates an instance of this controller and adds a message to the UserService event
        public UserController()
        {
            UserService = new UserService();
            UserService.Notify += SendWelcomeMessage;
        }

        // Method that creates an instance of User and calls the UserService method CreateUser
        public void RegisterUser(string n)
        {
            User user = new User { Name = n };
            UserService.CreateUser(user);
        }

        public void SendWelcomeMessage(User user)
        {
            Console.WriteLine($"Sending welcome to email to {user.Name}");
        }
    }
}