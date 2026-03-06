namespace WendingMachine;

public class Machine
{
    public Product[] ArrayProduct = new Product[2];

    public Machine()
    {
        ArrayProduct[0] = new Product()
        {
            Amount = 5,
            Price = 12,
            ProductName = "CoCaCola",
            UnicCode = "0001"
        };
        ArrayProduct[1] = new Product()
        {
            Amount = 5,
            Price = 12,
            ProductName = "fanta",
            UnicCode = "0002"
        };
    }

    public void PrintProducts()
    {
        foreach(Product product in ArrayProduct)
        {
            Console.WriteLine($@"peoductName:{product.ProductName} 
                                price:{product.Price} 
                                code:{product.UnicCode} 
                                amount:{product.Amount}");
        }
    }

    public void BuyProduct(string code)
    {
        foreach(Product product in ArrayProduct)
        {
            if(product.UnicCode == code)
            {
                product.Amount--;
            }
        }
    }
}
