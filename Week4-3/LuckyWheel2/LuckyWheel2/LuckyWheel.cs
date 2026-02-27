namespace LuckyWheel2;

public class LuckyWheel
{
    public string WordToGuess = "silver";
    public string WrongLetters { get; set; }
    public char[] CorrectLetters { get; set; }


    public void StoreLetters(char inputLetter)
    {
        bool checkout = false;
        for (int i = 0; i < WordToGuess.Length; i++)
        {
            if (WordToGuess[i] == inputLetter)
            {
                CorrectLetters[i] = inputLetter;
                checkout = true;
            }
        }

        if(checkout == false)
        {
            WrongLetters += inputLetter;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine("Wrong Letters: " + WrongLetters);

        for (int i = 0; i < CorrectLetters.Length; i++)
        {
            if (CorrectLetters[i] == '\0')
            {
                Console.Write('_');
            }
            else
            {
                Console.Write(CorrectLetters[i]);
            }
        }
        Console.WriteLine();
    }

    public void GameLogic()
    {
        CorrectLetters = new char[WordToGuess.Length];
        Person person = new Person();

        while (true)
        {
            PrintInfo();
            char letter = person.EnterLetter();
            if (letter == '0')
            {
                Console.WriteLine("Input data is in incorrect format");
                continue;
            }
            StoreLetters(letter);
            if (WordToGuess == new string(CorrectLetters))
            {
                Console.WriteLine("you guessed the word " + WordToGuess);
                break;
            }
        }
    }
}
