using ReadWriteIntoFile;

Market market = new();
string userName = Console.ReadLine();
string password = Console.ReadLine();
bool checkout = market.Login(userName,password);
if (checkout)
{
    market.PrintProducts();
}