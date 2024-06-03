using Newtonsoft.Json.Linq;



var client = new HttpClient();

//var city = "Norfolk";
//var state = "Va";
//var country = "USA";

var appsettingsText = File.ReadAllText("appsettings.json");
var apiKey = JObject.Parse(appsettingsText)["key"].ToString();


var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q=Norfolk,Va,USA&appid={apiKey}&units=imperial";
var response = client.GetStringAsync(weatherURL).Result;

Console.WriteLine(JObject.Parse(response)["main"]["temp"].ToString());

