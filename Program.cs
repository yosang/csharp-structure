using Controllers;

public class Program
{
    public static void Main()
    {
        var userController = new UserController();
        userController.RegisterUser("Yosmel");
    }
}