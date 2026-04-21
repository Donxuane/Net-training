using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Generics;

public class Generics12
{
    public void PrintInfo<T>(T parameter) 
    {
        if(parameter is int test)
        {
            Console.WriteLine($"parameter is int value {test}");
        }

        if(parameter is string testString)
        {
            Console.WriteLine($"parameter is int value {testString}");
        }

        var type = parameter.GetType();

        if(type.GetProperties().Length != 0)
        {
            Console.WriteLine(JsonSerializer.Serialize(type.GetProperties().Select(x=>x.Name)));
        }
    }

    public void UpdateTabele<T>(T parameter) where T : class
    {
        var command = @"update testclass t set name = @Name, description = @Description where t.id = @Id";
        StringBuilder stringBuilder = new StringBuilder();
        Dictionary<string, object> parameteres = new Dictionary<string, object>();
        stringBuilder.Append($"update {nameof(parameter).ToLower()} set ");

        var type = parameter.GetType();
        var properties = type.GetProperties();

        foreach( var property in properties )
        {
            if (property.Name != "Id")
            {
                stringBuilder.Append($"{property.Name.ToLower()} = @{property.Name},");
            }
            //var proValue = property.GetValue(parameter);
            parameteres.Add(property.Name, null);
        }

        stringBuilder.Append(@"where id = @Id");

        var query = stringBuilder.ToString();
    }
}