namespace ReadWriteIntoFile;

public class Market
{

    private string _path = Path.GetFullPath(
     Path.Combine(AppContext.BaseDirectory, @"..\..\..\data.txt"));


    public bool Login(string userName, string password)
    {
        string path = 
                Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\login.txt");

        using(StreamReader reader = new(path))
        {
            while (true)
            {
                try
                {
                    string line = reader.ReadLine();
                    if (line == null) break;

                    if (line.Contains(userName))
                    {
                        string[] data = line.Split(' ');
                        if (data[1] == password)
                        {
                            return true;
                        }
                    }
                    
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        return false;
    }

    public void PrintProducts()
    {
        using (StreamReader reader = new(_path))
        {
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
        }
    }
}