using System.Threading.Channels;

string login = "UserName";
string password = "Passw@rd1";

while (true)
{
    Console.Write("Write your ligin: ");
    string userLogin = Console.ReadLine();

    if (login == userLogin)
    {

        while (true)
        {
            Console.Write("Enter your password: ");
            string userPassword = Console.ReadLine();

            if (password == userPassword)
            {
                Console.WriteLine("You are loged in successfully");
                break;
            }
            else
                Console.WriteLine("Password is incorrect");
        }
        break;
    }
    else
        Console.WriteLine("We can not find your user, Please register");

}
Console.ReadLine();

