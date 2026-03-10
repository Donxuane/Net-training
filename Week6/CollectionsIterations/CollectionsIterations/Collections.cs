using System.Reflection.Metadata;

namespace CollectionsIterations;

public class Collections
{
    public void Iterate()
    {
        List<int> ints = new List<int> { 1, 2, 2, 3, 4 };

        ints.Add(12);

        ints.RemoveAll(x => x > 2);

        int count = ints.Count -1;
        ints.RemoveAt(0);

        Dictionary<string, int[]> dictionary = new Dictionary<string, int[]>();
        dictionary.Add("a", [1,2,3,3]);

        dictionary.Remove("a");
        dictionary.Clear();

        HashSet<int> inr = new HashSet<int>() { 1, 1, 2 };

        foreach (int i in inr)
        {
            Console.WriteLine(i);
        }

        int[] value = dictionary.GetValueOrDefault("a");
    }
}


public class Prudict
{
    public string Name { get; set; }
}