// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
string NameSurname = "Khatia Motskobili";
int age = 25;
char symbols = 'A';
double number = 0.2;
string name = NameSurname;
string proffesion = "veterinarian";

Console.WriteLine($"name {NameSurname}\n{age}\n{symbols}\n{number}\n{name}\n{proffesion}");

string fullinfo = NameSurname + " is " + age + " years old, she is " + proffesion;
Console.WriteLine( fullinfo );

