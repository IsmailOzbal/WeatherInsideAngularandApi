using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Libs.DTO
{
    public class WeatherModel
    {
        public Coordinate coord { get; set; }
        public List<Weather> weather { get; set; }
        public Main main { get; set; }

    }
}
