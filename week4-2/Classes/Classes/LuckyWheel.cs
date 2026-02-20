namespace Classes;

public class LuckyWheel
{
    public string WordToGuess { get; set; }
    public char[] CorrectLetters { get; set; }
    public string WrongLetters { get; set; }

    public bool InputLettersToGuessWord()
    {
        char letter = Convert.ToChar(Console.ReadLine());

        bool checkout = false;

        for (int i = 0; i < WordToGuess.Length; i++)
        {
            if (WordToGuess[i] == letter)
            {
                checkout = true;
                CorrectLetters[i] = letter;
                
            }
        }

        if(checkout == false)
        {
            WrongLetters += letter;
        }
        return checkout;

    }

    public void PrintStatistics()
    {
        foreach(char letter in CorrectLetters)
        {
            if(letter == '\0')
            {
                Console.Write('_');
            }
            else
            {
                Console.Write(letter);
            }
        }
        Console.WriteLine($"\nWrong Letters: {WrongLetters}");
    }

    public bool CheckoutGuessedLettersIfTheyMatchToTheDefinedWord()
    {

        if(new string(CorrectLetters) == WordToGuess)
        {
            return true;
        }

        return false;
    }

    public void GameLogic(string wordToGuess)
    {
        WordToGuess = wordToGuess;
        CorrectLetters = new char[WordToGuess.Length];
        WrongLetters = "";

        while (true)
        {
            PrintStatistics();
            InputLettersToGuessWord();
            bool checkoutGuessedWord = CheckoutGuessedLettersIfTheyMatchToTheDefinedWord();
            if (checkoutGuessedWord == true)
            {
                Console.WriteLine("you guessed the word");
                break;
            }
        }
    }
}
