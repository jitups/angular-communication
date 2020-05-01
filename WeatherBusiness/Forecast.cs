using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBusiness
{
    public class Forecast
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public int TempratureF { get; set; }

        public int Humidity { get; set; }

        public virtual City City { get; set; }
    }
}
