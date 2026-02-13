Console.Write("This application checks if number is even or odd.\n");
Console.Write("When you are asked for a number simply input any number you want.\n");
Console.Write("If you want to exit the app, enter 0.\n");
Console.WriteLine();
Console.WriteLine();

while (true)
{

    Console.WriteLine("Enter number: ");
    int inputnumber = Convert.ToInt32(Console.ReadLine());
    if (inputnumber == 0)
    {
        break;
    }
    if (inputnumber % 2 == 0)
    {
        Console.WriteLine("even\n");

    }
    else
    {
        Console.WriteLine("odd\n");

    }

}