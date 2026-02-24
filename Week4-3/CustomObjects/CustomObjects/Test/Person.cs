namespace CustomObjects.Test;

public class Person
{
    private string Name = "Vakhtangi";
    public string Surname = "Chitashvili";
    public int Age = 22;

    public Person()
    {
        Console.WriteLine("object Person is created");
    }
    public void PrintPrivateInfo()
    {
        Console.WriteLine(Name + ' ' + Surname + ' ' + Age);
    }

    public int GetAge()
    {
        Console.WriteLine("returning age");
        return Age;
    }

}


