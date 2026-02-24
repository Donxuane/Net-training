
using System.Data;
using System.Text;

int maxStudents = 10;

int[] scores = new int[maxStudents];
int circle = 0;

int max = 0;
int min = 0;
int sum = 0;
int failedStudentCount = 0;

while (circle < maxStudents)
{
    Console.WriteLine("Please enter score for a student " + (circle + 1));

    int score = Convert.ToInt32(Console.ReadLine());
    if (score >= 0 && score <= 100)
    {
        scores[circle] = score;
        circle++;

    }
    else
    {
        Console.WriteLine("error, please enter again. Score should beteween 0-100");
    }

    if(score <= 60)
    {
        failedStudentCount++;
    }
}





for (int i = 0; i < scores.Length; i++)
{

    sum = sum + scores[i];

     if(scores[i] > max)

        {
            max = scores[i];
        }

    if (scores[i] < min)
    {
        min = scores[i];
    }
}

int avarageScore = sum / scores.Length;

if (avarageScore > 85)
{
    Console.WriteLine("Team is strong");
}
else if (avarageScore < 60)
{
    Console.WriteLine("Team is weak");

}
else
{
    Console.WriteLine("Team is mid");
}

Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Avarage: " + avarageScore);
Console.WriteLine("Failed students: " + failedStudentCount);



string uniName = "agricultural university";
char[] letters = uniName.ToCharArray();
foreach (char c in uniName)
{
    Console.WriteLine(c);
}

StringBuilder stringBuilder = new StringBuilder();

foreach (char c in letters)
{
    
    stringBuilder.Append(c);
}

Console.WriteLine(stringBuilder.ToString());


Console.WriteLine(letters);

string[] shop = ["cucumber", "tomato", "cheese", "apple", "watermelon"];

foreach(string shopItem in shop)
{
    Console.WriteLine(shopItem);
}
string userInput = Console.ReadLine();
 Console.WriteLine(userInput);







