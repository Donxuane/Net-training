int[] studentsPoints = new int[10];

int index = 0;
while(index < studentsPoints.Length)
{
    int studentNumber = index + 1;
    Console.WriteLine($"Enter Point for student {studentNumber}: ");
    int point = Convert.ToInt32(Console.ReadLine());
    studentsPoints[index] = point;

    if (point < 0 || point > 100)
    {
        Console.WriteLine("Point outside of the boundry");
    }
    else
    {
        index++;
    }
}

int sumPoint = 0;

for(int i = 0; i< studentsPoints.Length; i++)
{
    sumPoint += studentsPoints[i];
}

int avaragePoint = sumPoint/ studentsPoints.Length;

int maxPoint = studentsPoints.Max();
int minPoint = studentsPoints.Min();

int maxPointAlgorithm = 0;
int minPointAlgorithm = studentsPoints[0];

foreach(int point in studentsPoints)
{
    if(maxPointAlgorithm < point)
    {
        maxPointAlgorithm = point; 
    }

    if(minPointAlgorithm > point)
    {
        minPointAlgorithm = point;
    }
}



foreach(int point in studentsPoints)
{
    if(point >= 90 && point <= 100)
    {
        Console.WriteLine($"point {point} - A");
    }
    else if (point >= 80 && point <= 89)
    {
        Console.WriteLine($"point {point} - B");
    }
    else if (point >= 70 && point <= 79)
    {
        Console.WriteLine($"point {point} - C");
    }
    else if (point >= 60 && point <= 69)
    {
        Console.WriteLine($"point {point} - D");
    }
    else
    {
        Console.WriteLine($"point {point} - F");
    }
}

for(int i = 0; i < studentsPoints.Length; i++)
{
    int studentPoint = studentsPoints[i];
    if (studentPoint >= 90 && studentPoint <= 100)
    {
        Console.WriteLine($"point {studentPoint} - A");
    }
    else if (studentPoint >= 80 && studentPoint <= 89)
    {
        Console.WriteLine($"point {studentPoint} - B");
    }
    else if (studentPoint >= 70 && studentPoint <= 79)
    {
        Console.WriteLine($"point {studentPoint} - C");
    }
    else if (studentPoint >= 60 && studentPoint <= 69)
    {
        Console.WriteLine($"point {studentPoint} - D");
    }
    else
    {
        Console.WriteLine($"point {studentPoint} - F");
    }
}

int countFailures = 0;

foreach (int point in studentsPoints)
{
    if(point< 60)
    {
        countFailures++;
    }
}




/*მაღაზის პროდუქტები : კიტრი, პამიდორი, ყველი, ვაშლი, ატამი foreach დაიბეჭდოს ეკრანზე 
უზერმა უნდა აირჩიოს ერთი რომელსაც აირჩევს ეკრანზე დავუბეჭდოთ შენ აირჩიე *ვაშლი */