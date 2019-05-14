using System.Threading.Tasks;
using Weather.Libs.DTO;
using Weather.Libs.Interface;


namespace Weather.Libs.BO
{
    public class GetWeatherInformationByCity : IWeather
    {
        private static IOpenWeatherMap _openWeatherMapService;

        public GetWeatherInformationByCity(IOpenWeatherMap openWeatherMapService)
        {
            _openWeatherMapService = openWeatherMapService;
        }
        public async Task<WeatherModel> GetWeatherInformationCityCritera(string cityInfo)
        {
            return await _openWeatherMapService.ReturnWeatherInformationByCity(cityInfo);
        }

    }
}
