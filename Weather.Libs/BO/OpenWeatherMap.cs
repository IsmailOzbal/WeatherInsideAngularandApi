using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Weather.Libs.DTO;
using Weather.Libs.Interface;

namespace Weather.Libs.BO
{
    public class OpenWeatherMap : IOpenWeatherMap
    {
        public async Task<WeatherModel> ReturnWeatherInformationByCity(string CityInfo)
        {
            string apiKey = MapApiKey.key;
            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.openweathermap.org/data/2.5/weather?q={CityInfo}&APPID={apiKey}");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<WeatherModel>(json);
            }
        }
    }
}
