///*
//წითელი, ყვითელი, ან მწვანე

//სამი შესაძლო გადმოცემული ვარიანტიდან თუ ემთხვევა ზემოთ ხსენებულ ფერებს ვბეჭდავთ ეკრანზე 
//თუ არ ემთხვევა გამოგვაქვს შეტყობინება "error"
// */
//int age = 21;
//if (age > 21)
//{
//    Console.WriteLine("is grater than 21");
//}
//else
//{
//    Console.WriteLine("is less or equal to 21");
//}


//if(age == 50)
//{
//    Console.WriteLine("test");
//}
//else if(age == 21)
//{
//    Console.WriteLine("test2");
//}
//else if (age >=21)
//{
//    Console.WriteLine("test3");
//}


while (true)
{
    Console.Write("first number: ");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
    Console.Write("logical operator: ");
    string logicalOperator = Console.ReadLine();
    Console.Write("second number: ");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

    if (logicalOperator == "+")
    {
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
    }
    else
    {
        Console.WriteLine("test");
    }
    Console.Write("Continue Execution? if so press space, to close app press z or Z");
    string appBreak = Console.ReadLine();

    if (appBreak == "Z"
        || appBreak == "z")
    {
        break;
    }
    else if (appBreak == " ")
    {
        continue;
    }
    else
    {
        break;
    }
}