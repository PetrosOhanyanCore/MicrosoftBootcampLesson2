string myDay = Console.ReadLine();

int day = Convert.ToInt32(myDay);

switch (day)
{
    case 1:        
    case 2:       
    case 3:        
    case 4:        
    case 5:
        Console.WriteLine("Working day");
        break;
    case 6:        
    case 7:
        Console.WriteLine("It is Holyday");
        break;

    default:
        Console.WriteLine("It is not day of the week");
        break;
}