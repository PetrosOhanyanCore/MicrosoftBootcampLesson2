int counter = 0;

while (counter < 5)
{
    counter++;
    Console.WriteLine("Now counter value is {0}", counter);
}
Console.WriteLine("Iteration count is {0}", counter);


int counter2 = 0;
while (counter2 < 10)
{
    counter2++;
    Console.WriteLine("Now counter2 value is {0}", counter2);

    break;

    Console.WriteLine("Not working part");
}
Console.WriteLine("Working part after {0} iteration", counter2);


int counter3 = 0;
while (counter3 < 10)
{
    counter3++;
    Console.WriteLine("Now counter3 value is {0}", counter3);

    continue;

    Console.WriteLine("Not working part");
}
Console.WriteLine("Working part after {0} iteration", counter3);
Console.ReadLine();
