User user = new User();

user.UserName = Console.ReadLine();
user.Password = Console.ReadLine();
user.Introduce();

System.Console.WriteLine();

string u, p;
u = Console.ReadLine();
p = Console.ReadLine();

user.Login(u,p);



