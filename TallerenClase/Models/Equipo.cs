using System.ComponentModel.DataAnnotations;

namespace TallerenClase.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public int Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }

    }
}
