using System;
using System.Net.Http;
using System.Threading.Tasks;
using VistasNain.Models;

namespace VistasNain.Consumidores
{
    public class PersonaConsumidor : IPersonaConsumidor
    {
        public HttpClient _clienteApi;

        public PersonaConsumidor()
        {
            _clienteApi = new HttpClient { BaseAddress = new Uri("https://localhost:44364/") };
        }

        public PersonaConsumidor(HttpClient cliente)
        {
            _clienteApi = cliente;
        }

        public void Dispose()
        {
            _clienteApi.Dispose();
        }

        public async Task<PersonaViewModel> ObtenerPersona()
        {
            HttpResponseMessage respuesta = await _clienteApi.GetAsync("api/Persona");
            return await respuesta.Content.ReadAsAsync<PersonaViewModel>();
        }
    }
}