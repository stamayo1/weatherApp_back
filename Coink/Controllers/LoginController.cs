using Weather.Data;
using Dato;
using System.Web.Http;

namespace Weather.Controllers
{
    public class LoginController : ApiController
    {
        public LoginResponse Post([FromBody] model oUsuario)//uso del metodo post con frombody e instanciando el objeto usuario
        {
            return UsuarioData.Login(oUsuario);//retorno de respuesta
        }
    }
}