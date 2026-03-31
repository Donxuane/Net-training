namespace BaseClasses;
public class InventoryItem
{

    public double X {  get;  }
    public InventoryItem(double x)
    {
        X = x;
        
    }

    //accessible for derived class to be extended
    public virtual void Print()
    {
        Console.WriteLine("test");
    }

}


public  class Food : InventoryItem
{
    public double X;
    public Food(double x):base(x)
    {
        X = x;
    }
    //overriding
    public override void Print()
    {
        Console.WriteLine(X);
    }

    //overloading
    public void Print(string value)
    {
        Console.WriteLine($"{value} {X}");
    }

    public int Print(int value, string text)
    {
        Console.WriteLine(text);
        return value;
    }

}