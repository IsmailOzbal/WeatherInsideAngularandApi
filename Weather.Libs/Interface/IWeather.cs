using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Libs.DTO;

namespace Weather.Libs.Interface
{
    public interface IWeather
    {
        Task<WeatherModel> GetWeatherInformationCityCritera(string cityInfo);
    }
}
