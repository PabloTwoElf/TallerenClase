using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerenClase.Models;

namespace TallerenClase.Data
{
    public class TallerenClaseContext : DbContext
    {
        public TallerenClaseContext (DbContextOptions<TallerenClaseContext> options)
            : base(options)
        {
        }

        public DbSet<TallerenClase.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<TallerenClase.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<TallerenClase.Models.Estadio> Estadio { get; set; } = default!;
    }
}
