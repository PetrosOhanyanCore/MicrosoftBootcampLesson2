double quantity = 10;
double price = 100;
double discount = 0.75;
double cost;

cost = quantity >= 10 ? quantity * price * discount : quantity * price;

Console.WriteLine("Total price is {0}", cost);
Console.ReadLine();