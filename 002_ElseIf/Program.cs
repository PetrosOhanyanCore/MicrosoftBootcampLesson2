long number1 = 12345, number2 = 67890;


while (true)
{


    if (number1 < number2)
    {
        Console.WriteLine("Number1 is smaller then number2");
    }
    else if (number1 == number2)
    {
        Console.WriteLine("Number1 is equal to number2");
    }
    else
    {
        Console.WriteLine("Number1 is bigger then number2");
        break;
    }
}