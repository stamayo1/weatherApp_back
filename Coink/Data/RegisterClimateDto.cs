using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class RegisterClimateDto
    {
        //libreria para reutilizar variables en todo el proyecto
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("humidity")]
            public double Humidity { get; set; }

            [JsonProperty("users_id")]
            public int UsersId { get; set; }

            [JsonProperty("city_name")]
            public string CityName { get; set; }

            [JsonProperty("climate_id")]
            public int ClimateId { get; set; }

            [JsonProperty("temperature")]
            public double Temperature { get; set; }

            [JsonProperty("temperature_max")]
            public double TemperatureMax { get; set; }

            [JsonProperty("temperature_min")]
            public double TemperatureMin { get; set; }

    }
}
