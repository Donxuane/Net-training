using Dapper;
using FirstMVCApplication.Models;
using Npgsql;

namespace FirstMVCApplication.Services;

public class Restaurant : IRestaurant
{
    private string connectionString = "Host=localhost;Port=5432;Database=khatiafirsttest;Username=postgres;Password=;";
    public List<Menu> GetMenus()
    {
        string query = @"select * from menu";
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            List<Menu> menus = (connection.Query<Menu>(query)).ToList();
            return menus;
        }
    }
}
