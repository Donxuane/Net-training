namespace LuckyWheel2;

public class Person
{
    public char EnterLetter()
    {
        string input = Console.ReadLine();
        char validChar = ValidateInputChar(input);
        return validChar;
    }

    private char ValidateInputChar(string input)
    {
        if(input.Length > 1)
        {
            return '0';
        }
        return char.Parse(input);
    }
}
