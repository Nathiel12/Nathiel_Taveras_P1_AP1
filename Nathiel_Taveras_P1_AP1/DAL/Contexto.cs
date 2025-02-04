using Microsoft.EntityFrameworkCore;
using Nathiel_Taveras_P1_AP1.Models;

namespace Nathiel_Taveras_P1_AP1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Modelo> Modelos { get; set; }

    }
}
