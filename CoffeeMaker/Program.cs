Console.WriteLine("Please enter 1 for light coffee, or 2 for middle or 3 for strong coffee");
Console.WriteLine("Do your choise ");

string coffeeSize = Console.ReadLine();


int cost = 0;

switch (coffeeSize)
{
    case "1":
        cost += 25;
        break;
    case "2":
        cost += 25;
        goto case "1";
    case "3":
        cost += 25;
        goto case "2";

    default:
        Console.WriteLine("Your choise is incorrect");
        break;
}


if (cost != 0)
{
    Console.WriteLine("Enter the money {0}", cost);
    Console.WriteLine("Thanks!");
}
else
{
    Console.WriteLine("Reply your choise");
}
Console.ReadLine();