namespace HttpRequests;

public class Service :test
{
    public async Task<string> GetResponse()
    {
        var client = new HttpClient();
        var results = await client.GetAsync("https://api2.myauto.ge/ka/services/quick-main-data/auction-autosalons-popular_mans/get");

        var responseBody = await results.Content.ReadAsStringAsync();
        if (!results.IsSuccessStatusCode)
        {
            throw new Exception("Request is invalid");
        }
        return responseBody; 


        
    }
}
