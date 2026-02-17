/* მაღაზის პროდუქტები : კიტრი, პამიდორი, ყველი, ვაშლი, ატამი 
აპლიკაციაში განსაზღრულია ეს პროდუქტები წინასწარ,
როდესაც მომხმარებელი შეიძენს პროდუცტს მაღაზიის აპლიკაციიდან უნდა გავაქროთ ეს პროდუქტი
(while) აპლიკაციამ უნდა იმუშაოს გაუჩერებლივ სანამ ყველა პროდუქტი არ გაიყიდება;
for- გამოყენებით შევამოწმოთ თუ არის ყველა ჩანაწერი კოლექციაში ცარიელი;
 */ 
string[] products = ["cucumber","tomato","cheese","apple","peach"];

Console.WriteLine($"Products for sale");
foreach (string product in products)
{
    Console.WriteLine($"\t{product}");
}

int countSoldProducts = 0;

while (true)
{
    Console.WriteLine("Enter the product you want to buy: ");
    string product = Console.ReadLine();

    bool checkout = false;
    int index = 0;
   
    for(int i = 0; i < products.Length; i++)
    {
        if (products[i] == product)
        {
            checkout = true;
            index = i;
            break;
        }
    }
    if(checkout == false)
    {
        Console.WriteLine("Product not found, try again");
        continue;
    }

    if(checkout == true)
    {
        products[index] = "";
        countSoldProducts++;
    }

    if(countSoldProducts == products.Length)
    {
        Console.WriteLine("all products are sold");
        break;
    }
}