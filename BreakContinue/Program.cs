const int maxValue = 5;
int start = 0;
string color = "red";

while (start < maxValue)
{
    start++;
    Console.WriteLine($"Start value now is {start}");

    string value = Console.ReadLine();

    if (value == "exit")
    {
        break;
    }
    if (value != color)
    {
        Console.WriteLine($"Your {start}'s trial, you have {maxValue - start} trials");
        continue;
    }
    Console.WriteLine($"You win! from {start} trial");
    break;
}
Console.ReadLine();