using Newtonsoft.Json.Linq;

HttpClient client = new();
HttpResponseMessage response = client.GetAsync("https://api.coinbase.com/v2/exchange-rates?currency=BTC").Result;
        
string str = response.Content.ReadAsStringAsync().Result;

JObject json = JObject.Parse(str);

float btcVal = (float)(json["data"]?["rates"]?["EUR"] ?? 0.0);
Console.Write(btcVal);
