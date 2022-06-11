using Weather.Data;
using Dato;
using System.Web.Http;

namespace Weather.Controllers
{
    public class UsuarioController : ApiController
    {
        public model Post([FromBody] model oUsuario)//uso del metodo post con frombody e instanciando el objeto usuario
        {
            return UsuarioData.Registrar(oUsuario);//retorno de respuesta
        }
    }
}