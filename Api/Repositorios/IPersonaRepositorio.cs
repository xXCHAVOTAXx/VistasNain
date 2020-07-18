using Api.Models;

namespace Api.Repositorios
{
    public interface IPersonaRepositorio
    {
        Persona ObtenerPersona();

        void Dormir();

        bool Comer();

        bool Cainar();
    }
}
