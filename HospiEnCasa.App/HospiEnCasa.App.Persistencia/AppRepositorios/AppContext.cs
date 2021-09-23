using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Medico> Medicos{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQlocalDB; Initial Catalog=HospiEnCasa.Data");
            }
        }
    }
}