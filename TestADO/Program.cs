using TestADO.Manager;

public class Program
{
    public static void Main(string[] args)
    {
        IUserManager userManager = new UserManager();
        userManager.ListUsers();
    }
}