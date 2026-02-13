//დავალება #4 არჩევითი//

while (true)
{
    int age = Convert.ToInt32(Console.ReadLine());
    if (age == -1)
    {
        break;
    }
    else if (age < 0)

    {
        Console.WriteLine("invalide age");
    }
     else if (age >= 0 && age <= 18)
    {
        Console.WriteLine("You are minor");
    }
    else if (age > 18 && age <= 65)
    {
        Console.WriteLine(" you are adult");

    }
    else if (age >= 65)
    {
        Console.WriteLine("you are senior");

    }
    

}

//დავალება სავალდებულო//






