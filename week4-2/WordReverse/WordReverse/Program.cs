string wordToGuess = "potato";

char[] correctLetters = new char[wordToGuess.Length];

string wrongLetters = "";

int wrongLettersIndex = 0;

while (true)
{
    Console.Write("Correct Letters: ");
    foreach(char c in correctLetters)
    {
        if(c == '\0')
        {
            Console.Write('_');
        }
        else
        {
            Console.Write(c);
        }
    }
    Console.WriteLine($"\nwrong letters: {wrongLetters}");
    Console.WriteLine("Enter letter: ");
    char letter = Convert.ToChar(Console.ReadLine());
    bool checkCorrectLetter = false;
    for(int i = 0; i < wordToGuess.Length; i++)
    {
        if(letter == wordToGuess[i])
        {
            correctLetters[i] = letter;
            checkCorrectLetter = true;
        }
    }

    if(checkCorrectLetter == false)
    {
        Console.WriteLine($"Letter was incorrect: {letter}");
        wrongLetters += letter;
        wrongLettersIndex++;
    }

    if(new string(correctLetters) == wordToGuess)
    {
        Console.WriteLine($"you guessed the word {wordToGuess}");
        break;
    }

    if(wrongLettersIndex == 3)
    {
        Console.WriteLine("You Lost, Try Again (y), Exit(z)");
        char menu = Convert.ToChar(Console.ReadLine());
        if(menu == 'y')
        {
            wrongLettersIndex = 0;
            wrongLetters = "";
            for(int i = 0; i< correctLetters.Length; i++)
            {
                correctLetters[i] = '\0';
            }
        }
        else if(menu == 'z')
        {
            break;
        }
        else
        {
            break;
        }
    }

}
