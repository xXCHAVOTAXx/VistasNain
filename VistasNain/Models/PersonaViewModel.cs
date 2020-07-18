using System.ComponentModel.DataAnnotations;

namespace VistasNain.Models
{
    public class PersonaViewModel
    {
        [Display(Name = "Nombre de la persona")]
        [EmailAddress]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public bool EsPuto { get; set; }
    }
}