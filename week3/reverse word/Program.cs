int[] numbers = [12, 15, 13, 45, 23, 76];

for (int i = 0; i < numbers.Length; i++)

{
    Console.WriteLine(numbers[i]);
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}




string[] words = { "hello", "world", "cat", "dog" };

foreach (string word in words)
{
    for (int i = word.Length - 1; i >= 0; i--)
    {
        Console.Write(word[i]);
    }

    Console.WriteLine();
}