namespace Oop;

public abstract class MainAnimal
{
    public MainAnimal()
    {
        Console.WriteLine("Creating abstract class");
    }

    public void TestMethod()
    {
        Console.WriteLine("test");
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("COnsole");
    }
}
