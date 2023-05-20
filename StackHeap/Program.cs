//int a = 1;

using System.Text;

int b = 6;







//b = a;

//Console.WriteLine($"a variable value is {a}");
//Console.WriteLine($"b variable value is {b}");
//Console.ReadLine();


int[] firstArr = new int[1];
firstArr[0] = 1;


int[] secontArr;
secontArr = firstArr;

secontArr[0] = 0;

Console.WriteLine($"First Arrays first value is {firstArr[0]}");
Console.WriteLine($"Second Arrays first value is {secontArr[0]}");
Console.ReadLine();


