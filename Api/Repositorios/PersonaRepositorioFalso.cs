using Api.Models;
using System;

namespace Api.Repositorios
{
    public class PersonaRepositorioFalso : IPersonaRepositorio
    {
        public bool Cainar()
        {
            throw new NotImplementedException();
        }

        public bool Comer()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {
            throw new NotImplementedException();
        }

        public Persona ObtenerPersona()
        {
            return new Persona
            {
                Nombre = "Pablo Marmol",
                Edad = 40,
                EsPuto = true
            };
        }
    }
}