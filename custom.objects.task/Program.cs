/*using System;



class Book

{
    public string title = "sherlock";
    public string author = "arthur conan doyle";
    public int pages = 1000;

    public Book()
    {
        Console.WriteLine("Book object created");
    }
}
class Program
{
    static void Main()
    {
        Book myBook = new Book();

        Console.WriteLine(myBook.title);
        Console.WriteLine(myBook.author);
        Console.WriteLine(myBook.pages);
    }
}

class Car

{
    public string brand = "porsche";
    public string model = "panamera";
    public int year = 2022;

    public Car()
    {
        Console.WriteLine("car object created");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        Console.WriteLine(car.brand);
        Console.WriteLine(car.model); 
        Console.WriteLine(car.year);
    }
}
*/




using custom.objects.task;

ArrowMakerGame Game = new ArrowMakerGame();
Game.GameLogic();