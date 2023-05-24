int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = i * 2;
}

for (int k = 0; k < array.Length; k++)
{
    Console.WriteLine(array[k]);
}

Console.WriteLine("_______________________________________________________________________________________");


int[] ints = new int[5] { 1, 2, 3, 4, 5 };
for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine(ints[i]);
}
Console.ReadLine();


Console.WriteLine("_______________________________________________________________________________________");


int[,] matrix = new int[3, 3];


matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;

matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;

matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

Console.WriteLine(matrix[0,0]);
Console.WriteLine(matrix[0, 1]);
Console.WriteLine(matrix[0, 2]);
Console.Write("\n");

Console.WriteLine(matrix[1, 0]);
Console.WriteLine(matrix[1, 1]);
Console.WriteLine(matrix[1, 2]);
Console.Write("\n");

Console.WriteLine(matrix[2, 0]);
Console.WriteLine(matrix[2, 1]);
Console.WriteLine(matrix[2, 2]);
Console.Write("\n");
Console.ReadLine();
