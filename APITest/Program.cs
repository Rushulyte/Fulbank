using Newtonsoft.Json.Linq;

var client = new HttpClient();
var response = client.GetAsync("https://api.coinbase.com/v2/exchange-rates?currency=BTC").Result;
        
var str = response.Content.ReadAsStringAsync().Result;

JObject json = JObject.Parse(str);

float btcVal = (float)(json["data"]?["rates"]?["EUR"] ?? 0.0);
Console.Write(btcVal);

