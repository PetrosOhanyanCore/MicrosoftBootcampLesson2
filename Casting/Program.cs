int myInt = 200;
byte myByte = 0;


myByte = (byte)(myInt);

Console.WriteLine(myByte);
Console.ReadKey();


#region Casting Const

const int i = 255;
byte j = 0;

j = i;
Console.WriteLine(j);
Console.ReadKey();


const float myFloat = 255;
byte nByte = 0;

nByte = (byte)myFloat;

Console.WriteLine(nByte);
Console.ReadKey();
#endregion