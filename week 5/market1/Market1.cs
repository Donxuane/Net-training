using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace market1;

public class Market1
{
    public List<string> userProduct = new List<string>();
    public Dictionary<string, int> Products;

    public Market1()
    {
        Products = new Dictionary<string, int>()
        {
            { "apple", 2 },
            { "bannana", 3 },
            { "bread", 1 }

        };
    }
    public void PrintInfo()
    {
        foreach (var product in Products)
        {
            Console.WriteLine($"{product.Key} - Quantity: {product.Value}");
        }
    }

   
       public void BuyProduct(string productName)
    {
        if (Products.ContainsKey(productName))
        {
            if (Products[productName] > 0)
            {
                Products[productName]--;
                Console.WriteLine(productName + " bought. Remaining: " + Products[productName]);
            }
            else
            {
                Console.WriteLine("No stock left for " + productName);
            }
        }
        else
        {
            Console.WriteLine("Product does not exist");
        }
    }

}
    







