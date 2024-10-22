using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerenClase.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        [Required]

        public string Ciudad { get; set; }

        public int Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }

        public Estadio? Estadio { get; set; }

        [ForeignKey("Estadio")]

        public int? IdEstadio { get; set; }
        


    }
}
