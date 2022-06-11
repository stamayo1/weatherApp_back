using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class LoginResponse
    {
        //libreria para reutilizar variables en todo el proyecto
        [JsonProperty("users_id")]
        public int UsersId { get; set; }

    }
}
