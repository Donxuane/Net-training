using FirstMVCApplication.Models;
using FirstMVCApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApplication.Controllers;

public class RestaurantController : Controller
{
    private readonly IRestaurant _restaurant;

    public RestaurantController(IRestaurant restaurant)
    {
        _restaurant = restaurant;
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult RegisterUser(string Name, string Email)
    {
        Console.WriteLine(Name + Email);
        return Menu();
    }

    public IActionResult Menu()
    {
        List<Menu> menu = _restaurant.GetMenus();

        return View("Register", menu);
    }
}
