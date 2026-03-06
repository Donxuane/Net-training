using WendingMachine;

Machine wendingMachine = new Machine();
while (true)
{
    wendingMachine.PrintProducts();
    string code = Console.ReadLine();
    wendingMachine.BuyProduct(code); 
}