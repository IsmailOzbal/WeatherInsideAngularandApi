using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weather.Libs.Interface;

namespace AngularWeather.Controller
{
    public class WeatherController : ControllerBase
    {
        private readonly IWeather _getWeatherServicesByCity;
        private readonly ICity _getCities;
        public WeatherController(IWeather getWeatherServicesByCity, ICity getCities)
        {
            _getWeatherServicesByCity = getWeatherServicesByCity;
            _getCities = getCities;
        }

        [HttpGet]
        [Route("v1/openWeatherMap/Information/{cityInfo}")]
        public async Task<IActionResult> GetWeatherInformationByCity(string cityInfo)
        {
            cityInfo = cityInfo + "," + "tr";

            var result = await _getWeatherServicesByCity.GetWeatherInformationCityCritera(cityInfo);

            return Ok(result);
        }

        [HttpGet]
        [Route("v1/GetCities")]
        public IActionResult GetAllCities()
        {
            var result = _getCities.GetAll();

            return Ok(result);
        }

    }
}