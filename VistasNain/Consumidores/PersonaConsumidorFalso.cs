using System.Threading.Tasks;
using VistasNain.Models;

namespace VistasNain.Consumidores
{
    public class PersonaConsumidorFalso : IPersonaConsumidor
    {
        public async Task<PersonaViewModel> ObtenerPersona()
        {
            return new PersonaViewModel
            {
                Nombre = "Juan Camanei",
                Edad = 24,
                EsPuto = false
            };
        }
    }
}