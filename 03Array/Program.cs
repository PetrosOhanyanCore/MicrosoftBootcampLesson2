int[,,] array = new int[3, 3, 3];

array[0, 0, 0] = 1;
array[0, 0, 1] = 2;
array[0, 0, 2] = 3;
array[0, 1, 0] = 4;
array[0, 1, 1] = 5;
array[0, 1, 2] = 6;
array[0, 2, 0] = 7;
array[0, 2, 1] = 8;
array[0, 2, 2] = 9;

array[1, 0, 0] = 10;
array[1, 0, 1] = 20;
array[1, 0, 2] = 30;
array[1, 1, 0] = 40;
array[1, 1, 1] = 50;
array[1, 1, 2] = 60;
array[1, 2, 0] = 70;
array[1, 2, 1] = 80;
array[1, 2, 2] = 90;

array[2, 0, 0] = 100;
array[2, 0, 1] = 200;
array[2, 0, 2] = 300;
array[2, 1, 0] = 400;
array[2, 1, 1] = 500;
array[2, 1, 2] = 600;
array[2, 2, 0] = 700;
array[2, 2, 1] = 800;
array[2, 2, 2] = 900;


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine("x={0 },y={1 },z={2 } element value is {3}", i, j, k, array[i, j, k]);
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}
Console.ReadLine();