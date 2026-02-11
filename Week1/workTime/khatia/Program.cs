//// See https://aka.ms/new-console-template for more information
//using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Hello, World!");
//string NameSurname = "Khatia Motskobili";
//int age = 25;
//char symbols = 'A';
//double number = 0.2;
//string name = NameSurname;
//string proffesion = "veterinarian";

//Console.WriteLine($"name {NameSurname}\n{age}\n{symbols}\n{number}\n{name}\n{proffesion}");

//string fullinfo = NameSurname + " is " + age + " years old, she is " + proffesion;
//Console.WriteLine( fullinfo ); 


/*

int მთელი რიცხვი
long უფრო დიდი მთელი რიცხვი
float ათწილადი
double უფრო დიდი ათწილადი
string ტექსტი
bool True False იგივე 0 1

if შედარების ოპერატორები
> მეტია. თუ პირველი ელემენტი მეტია მეორე ელემენტზე
< ნაკლებია.












int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{ 
    Console.WriteLine(number);
}
else 
{
    Console.WriteLine("The number is negative or zero.");
        } 

int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18 )
{
    Console.WriteLine("You are of legal age.");
} 
else 
{ Console.WriteLine(" you are not Of legal age");

}



int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 % 2==0)
{
    Console.WriteLine("even");

}
else
{
    Console.WriteLine("odd");
}

// დავალება #1//

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
string mathOperator = Console.ReadLine();

if (mathOperator == "+")
{
    Console.WriteLine(firstNumber + secondNumber);
}
else if (mathOperator == "-")
{
    Console.WriteLine(firstNumber - secondNumber);
}
else if (mathOperator == "*")
{
    Console.WriteLine(firstNumber * secondNumber);
}
else if (mathOperator == "/")
{
    Console.WriteLine(firstNumber / secondNumber);
}
else if (mathOperator == "sqrt")
{
    Console.WriteLine(Math.Sqrt(firstNumber));
    Console.WriteLine(Math.Sqrt(secondNumber));
}
else
{
    Console.WriteLine("გამოიყენეთ მხოლოდ +, -, *, /, sqrt");
} 

//დავალება #2//
int a = 15;
int b = 25;

int sum = a + b;
Console.WriteLine("sum = " + sum);
int difference = a - b;
Console.WriteLine("difference = " +  difference);
int multiplication = (a * b);
Console.WriteLine("multiplication = " +  multiplication);
double division = ((double)a / b);
Console.WriteLine("division = " +  division);

Math.Sqrt(a); 
Console.WriteLine("square root of 15 = " +  Math.Sqrt(a));
Math.Sqrt(b);
Console.WriteLine("square root of 25 = " + Math.Sqrt(b));

Console.WriteLine("The square of 15 = " + Math.Pow (a, 2));
Console.WriteLine("The square of 25 = " + Math.Pow(b, 2));
*/

string nameSurname = "Khatia Motskobili";
int numbofApples = 15;
double riceKg = 3.5;
bool canlift15Kg = false;

Console.WriteLine($"{nameSurname}\n {numbofApples}\n {riceKg}\n {canlift15Kg}");

