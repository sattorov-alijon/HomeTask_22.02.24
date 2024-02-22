namespace Tasc2;

public class User
{
public string _firstName;
public string _lastName;
public string _username;
public string _password;
public bool _isLoggedIn;

public void Login(string username,string password)
{
    if (_username==username && _password==password)
    {
     System.Console.WriteLine("User logged in successfully");   
     _isLoggedIn=true;
    }
    else
    {
        System.Console.WriteLine("Your password or username is incorrect");
    }
}

public void Logout()
{
_isLoggedIn=false;
}
public string GetFullInfo()
{
    return $"{_firstName}   {_lastName}  - {_isLoggedIn}";
}
}
