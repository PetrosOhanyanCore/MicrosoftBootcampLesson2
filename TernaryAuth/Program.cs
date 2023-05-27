string @string = "Hello ";

Console.WriteLine("Enter your login: ");

string login = Console.ReadLine();

@string += login == "Admin" ? "Administrator" : "User";

Console.WriteLine(@string);

Console.ReadLine();