using System.Threading.Tasks;
using VistasNain.Models;

namespace VistasNain.Consumidores
{
    public interface IPersonaConsumidor
    {
        Task<PersonaViewModel> ObtenerPersona();
    }
}
