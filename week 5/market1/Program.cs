using market1;


using market1;

Market1 market = new Market1();

while (true)
{
    Console.WriteLine("\nAvailable products:");
    market.PrintInfo();

    Console.WriteLine("Enter product name (or type exit):");
    string productName = Console.ReadLine();

    if (productName == "exit")
        break;

    market.BuyProduct(productName);
}