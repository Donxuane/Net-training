using Dapper;
using Npgsql;

namespace RestaurantMenu;

public class Restaurant : IRestaurant
{
    private const string connectionToKhatiasFirstDatabase = "Host=localhost;Port=5432;Database=khatiafirsttest;Username=postgres;Password=;";
    public List<Menu> GetMenu()
    {
        string query = @"select foodname, price from menu";
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionToKhatiasFirstDatabase))
        {
            connection.Open();
            var result = connection.Query<Menu>(query);
            return result.ToList();
        }
    }
}
