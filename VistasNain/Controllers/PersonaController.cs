using System.Threading.Tasks;
using System.Web.Mvc;
using VistasNain.Consumidores;
using VistasNain.Models;

namespace VistasNain.Controllers
{
    public class PersonaController : Controller
    {
        IPersonaConsumidor _consumidor;

        public PersonaController()
        {
            _consumidor = new PersonaConsumidor();
            //_consumidor = new PersonaConsumidorFalso();
        }

        // GET: Persona
        public async Task<ActionResult> Index()
        {
            PersonaViewModel persona = await _consumidor.ObtenerPersona();
            return View(persona);
        }
    }
}