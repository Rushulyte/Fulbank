using Newtonsoft.Json;

namespace APITest;

public class ApiResponse
{
    public readonly Currency Data;
    public ApiResponse(Currency data)
    {
        Data = data;
    }
}

public class Currency
{
    public readonly string CurrencyName;
    public readonly Dictionary<string, double> Rates;
    
    public Currency(string currency, Dictionary<string, double> rates)
    {
        CurrencyName = currency;
        Rates = rates;
    }
}

static class Program
{
    public static void Main(string[] args)
    {
        HttpClient client = new();
        HttpResponseMessage response = client.GetAsync("https://api.coinbase.com/v2/exchange-rates?currency=BTC").Result;
        
        string str = response.Content.ReadAsStringAsync().Result;
        ApiResponse? r = JsonConvert.DeserializeObject<ApiResponse>(str);

        if (r == null) return;
        float btcVal = (float)(r.Data.Rates["EUR"]);
        Console.Write(btcVal);
    }
}