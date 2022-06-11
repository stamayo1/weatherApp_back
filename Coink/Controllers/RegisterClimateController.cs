using Weather.Data;
using Dato;
using System.Web.Http;

namespace Weather.Controllers
{
    public class RegisterClimateController : ApiController
    {
        public RegisterClimateDto Post([FromBody] RegisterClimateDto oRegister)//uso del metodo post con frombody e instanciando el objeto usuario
        {
            return UsuarioData.RegisterClimate(oRegister);//retorno de respuesta
        }
    }
}