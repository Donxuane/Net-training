

while (true)
{
    Console.WriteLine("Calculator");
    Console.WriteLine("firs Number");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("operation");
    string operation = Console.ReadLine();
    Console.WriteLine("second Number");
    double secondNumber = Convert.ToDouble(Console.ReadLine());
    if (operation == "+")
    {
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
    }
    Console.Write("Continue Execution?if so press T,and close app press d or D");
    string appbreak = Console.ReadLine();
    if (appbreak == "d"
            || appbreak == "D")
    {
        break;
    }
   else if (appbreak == "T")
    {
        continue;
    }
    else
    {
        break;
    }
}
//
while (true)
{
    Console.WriteLine("Calculator minus");
    Console.WriteLine("firstNumber");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Operator");
    string Operator = Console.ReadLine();
    Console.WriteLine("secondNumber");
    double secondNumber = Convert.ToDouble(Console.ReadLine());
    if (Operator == "/")
    {
        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
    }
    Console.WriteLine("continiue execution? if so press S, and to close app press space");
    string appbreak = Console.ReadLine();
    if (appbreak == " ")
    {
        break;
    }
    else if (appbreak == "S")
    {
        continue;
    }
    else
    {
        break;
    }
}
