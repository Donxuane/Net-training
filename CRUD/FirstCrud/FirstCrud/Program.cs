// See https://aka.ms/new-console-template for more information
using FirstCrud;

Console.WriteLine("Hello, World!");


Test test = new Test { Id = 5, IsAdult = true ,Name = "Tornike", SurName = "Beradze"};

Crud crud = new Crud();

List<Test> collection = crud.GetData();

foreach(Test col in collection)
{
    Console.WriteLine($"{col.Id}, {col.Name}, {col.SurName}, {col.IsAdult}");
}