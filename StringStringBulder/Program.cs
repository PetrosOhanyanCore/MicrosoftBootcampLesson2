////String char[]

using System.Security.Principal;
using System.Text;

string first = "Hello";
string second = "world";

string third = new String(new char[] { 'H', 'e', 'l', 'l', 'o' });

Console.WriteLine(first);
Console.WriteLine(third);
Console.WriteLine(first == third);

Console.WriteLine(first[2]);




///Compare//////
string stringOne = "hello";
string stringTwo = "hello";

int returnResult = string.Compare(stringOne, stringTwo);
Console.WriteLine(returnResult);


///Remove/////
string removeString = "Samsung";
int index = removeString.Length - 2;
removeString = removeString.Remove(index);
Console.WriteLine(removeString);


////EndsWith/StartsWith
string[] cars = new string[]
{
    "Chevrolet.GM",
    "Chrysler.Dodge",
    "Lincoln.GM",
    "Cherry.Non",
    "BMW.GM"
};

for (int i = 0; i < cars.Length; i++)
{
    if (cars[i].EndsWith(".GM"))
    {
        Console.WriteLine(cars[i]);
    }
}

/////IndexOf
string indexString = "General Motors";
char ch = 'e';
int charIndex = indexString.IndexOf(ch);
Console.WriteLine(charIndex);


////Insert
string console = "Console read";
string subConsole = "Always ";

console = console.Insert(8, subConsole);
Console.WriteLine(console);



////Join
string firstCompany = "Betconstruct";
string secondCompnay = "Apple";
string thirdCompany = "Windows";
string[] companies = new string[] { firstCompany, secondCompnay, thirdCompany };

string allCompanies = string.Join(", ", companies);
Console.WriteLine("{0} + {1}", allCompanies, firstCompany);
Console.WriteLine($"{allCompanies} + {firstCompany}");



////Replace
string fullText = "Console WriteLine";
string replacedString = "ReadLine";

fullText = fullText.Replace("WriteLine", "ReadLine");
Console.WriteLine(fullText);



////ToLower, ToUpper
string yerevan = "Yerevan";

Console.WriteLine(yerevan.ToLower());
Console.WriteLine(yerevan.ToUpper());


////Trim
string countryCapital = " Armenia Yerevan ";
countryCapital = countryCapital.Trim();
Console.WriteLine(countryCapital);
countryCapital = countryCapital.Trim(new char[] { 'n', 'A' });
Console.WriteLine(countryCapital);


//////////StringBuilder

StringBuilder sb = new StringBuilder("Name: ");
Console.WriteLine(sb);
Console.WriteLine(sb.Length);
Console.WriteLine(sb.Capacity);

sb.Append(firstCompany);
Console.WriteLine(sb.Length);
Console.WriteLine(sb.Capacity);
Console.WriteLine(sb);

Console.ReadKey();




