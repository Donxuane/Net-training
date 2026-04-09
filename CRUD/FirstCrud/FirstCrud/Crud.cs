using Dapper;
using Npgsql;

namespace FirstCrud;

public class Crud
{
    public string ConnectionString = "Host=localhost;Port=5432;Database=khatiafirsttest;Username=postgres;Password=;";
    public void InsertData(Test test)
    {
        var command = @"insert into test (id,name,surname,isadult )
                            values(@Id,@Name,@Surname,@IsAdult);";
        using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
        {
            connection.Open();
            connection.Execute(command, test);
        }
    }

    public List<Test> GetData()
    {
        string query = "select * from test;"; 
        using var connection = new NpgsqlConnection(ConnectionString);
        connection.Open();
        return (connection.Query<Test>(query)).ToList();
        
    }
}
