using Tasc2;

var user=new User();
user._firstName="Alijon";
user._lastName="Sattorov";
user._username="alijon";
user._password="909070718";
user.Login("alijon","909070718");
System.Console.WriteLine(user.GetFullInfo());
user.Logout();
System.Console.WriteLine();
System.Console.WriteLine(user.GetFullInfo());

