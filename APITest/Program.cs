using Newtonsoft.Json;

public class APIResponse
{
    public Currency Data;
}

public class Currency
{
    public string currency;
    public Dictionary<string, double> Rates;
}

static class Program
{
    public static void Main(string[] args)
    {
        HttpClient client = new();
        HttpResponseMessage response = client.GetAsync("https://api.coinbase.com/v2/exchange-rates?currency=BTC").Result;
        
        string str = response.Content.ReadAsStringAsync().Result;
        APIResponse? r = JsonConvert.DeserializeObject<APIResponse>(str);

        if (r == null) return;
        float btcVal = (float)(r.Data.Rates["EUR"]);
        Console.Write(btcVal);
    }
}
