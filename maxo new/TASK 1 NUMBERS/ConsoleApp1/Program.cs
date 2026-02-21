

        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);
            if (i > 0)
                Console.Write(", ");
        }
        Console.WriteLine("]");
//
int[] numbers2 = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i]);
    if (i < numbers2.Length - 1)
        Console.Write(", ");
}
Console.WriteLine("]");
