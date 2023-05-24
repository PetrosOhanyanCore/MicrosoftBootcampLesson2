int counter = 0;

do
{
    counter++;
    if (counter == 4)
    {
        continue;
    }

    Console.WriteLine("counter value is {0}", counter);
 
}
while (counter < 6);

Console.WriteLine("Iteration counts are {0}", counter);
Console.ReadLine();