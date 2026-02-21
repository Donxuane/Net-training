string[] words = { "cat", "dog", "code" };
foreach(string word in words)
{
    for(int i =word.Length-1; i>=0; i--)
    {
        Console.Write(word[i]);
    }
    Console.WriteLine();
}
