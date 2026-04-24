using FirstMVCApplication.Models;

namespace FirstMVCApplication.Services;

public interface IRestaurant
{
    public List<Menu> GetMenus(); 
}
