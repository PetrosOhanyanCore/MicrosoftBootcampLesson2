int[,] array = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array[i, j] = i * j + 1;
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("{0} ", array[i, j]);
    }
    Console.Write("\n");
}
Console.ReadLine();





int[,] array_2 =
{
    {
        1, 2, 3,
    },
    {
        4,5,6
    },
    {
        7,8,9
    }
};

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("{0} ", array_2[i, j]);
    }
    Console.Write("\n");
}
Console.ReadLine();


int[] vector = new int[1];
vector[0] = 100;
Console.WriteLine(vector[0]);

int[,] matrix = new int[1, 1];
matrix[0, 0] = 100;
Console.WriteLine(matrix[0, 0]);


Console.ReadLine();