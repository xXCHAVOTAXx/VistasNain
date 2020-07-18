using Api.Repositorios;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class PersonaController : ApiController
    {
        IPersonaRepositorio _repositorio;

        public PersonaController()
        {
            //_repositorio = new PersonaRepositorio();
            _repositorio = new PersonaRepositorioFalso();
        }

        public HttpResponseMessage Get()
        {
            var persona = _repositorio.ObtenerPersona();
            return Request.CreateResponse(HttpStatusCode.OK, persona);
        }
    }
}
