
int[] scores = new int[10];
int i = 0;
while (i < 10)
{

    int score = Convert.ToInt32(Console.ReadLine());
    if (score >= 0 && score <= 100)
    {
        scores[i] = score;
        i++;

    }
    else
    {
        Console.WriteLine("error, please enter again");
    }
}

    
    


