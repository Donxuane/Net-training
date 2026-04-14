using RestaurantMenu;

IRestaurant restaurant = new Restaurant();

List<Menu> menu = restaurant.GetMenu();

foreach (Menu m in menu)
{
    Console.WriteLine($"{m.FoodName} - {m.Price}");
}