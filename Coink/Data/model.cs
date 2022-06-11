using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class model
    {
        //libreria para reutilizar variables en todo el proyecto
        [JsonProperty("users_id")]
        public int UsersId { get; set; }

        [JsonProperty("users_name")]
        public string UsersName { get; set; }

        [JsonProperty("users_email")]
        public string UsersEmail { get; set; }

        [JsonProperty("users_password")]
        public string UsersPassword { get; set; }

        [JsonProperty("users_creationdate")]
        public DateTime UsersCreationdate { get; set; }

    }
}
