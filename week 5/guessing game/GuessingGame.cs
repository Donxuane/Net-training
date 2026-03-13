using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game;

internal class GuessingGame
{
    public int CorrectNumber { get; set; }

    public GuessingGame(int correctNumber)
    {
        CorrectNumber = correctNumber;
    }

    public bool Guess(int number)
    {
        if (number < CorrectNumber)

        { Console.WriteLine("too low"); }

        else if (number > CorrectNumber)

        { Console.WriteLine("too high"); }

        else

        {
            Console.WriteLine("correct");

            return true;

        }
        return false;
        


    }
    public void GameLogic()
    {
       

        while (true)
        {
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber ==0)
            {
                break;
            }

            else if(Guess(userNumber)==true)
            {
                break;
            }
            bool log = Guess(userNumber);
        }
    }
}
