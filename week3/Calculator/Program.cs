Console.Write("Perform mathematical operations\n");


while (true)

{
    Console.Write("first number: ");
    double firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("math operator: ");
    string mathOperator = Console.ReadLine();
    Console.Write("second number: ");
    double secondNumber = Convert.ToInt32(Console.ReadLine());


    if (mathOperator == "+")
    {
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");

    }
    else if (mathOperator == "-")
    {
        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
    }
    else if (mathOperator == "*")
    {
        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
    }
    else if (mathOperator == "/")
    {
        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
    }
    else if (mathOperator == "sqrt")
    {
        Console.WriteLine(Math.Sqrt(firstNumber));
        Console.WriteLine(Math.Sqrt(secondNumber));
    }
    else
    {
        Console.WriteLine("გამოიყენეთ მხოლოდ +, -, *, /, sqrt");

    }
    Console.Write("if you want exit app, enter: close\n");
    string appbreak = Console.ReadLine();

    if (appbreak == "close")
    {
        break;
    }
    else if (appbreak == " ")

    {
        continue;

    } else 
    {
        break;
    }
}
