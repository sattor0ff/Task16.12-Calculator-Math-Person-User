public class User
{
    public string UserName;
    public string Password;

    public void Introduce()
    {
        System.Console.WriteLine($"I am {UserName}");
    }
    public void Login(string username, string password)
    {
        if(username == UserName && password == Password)
        {
            System.Console.WriteLine($"Welcome {UserName}");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
    }
}
