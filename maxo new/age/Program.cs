Console.WriteLine("age");
while (true)
{
    int age = Convert.ToInt32(Console.ReadLine());
    if (age == -1)
    {
        break;
    }
    else if (age < 0)
    {
        Console.WriteLine("invalid age");
    }
    else if (age > 0 && age < 18)
    {
        Console.WriteLine("you are minor");
    }
    else if (age >= 18 && age < 65)
    {
        Console.WriteLine("you are adult");
    }

    else if (age >= 65)
    {
        Console.WriteLine("you are Senior");
    }

}