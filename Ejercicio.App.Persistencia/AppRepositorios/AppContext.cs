using Microsoft.EntityFrameworkCore;
using Ejercicio.App.Dominio;

namespace Ejercicio.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Dentro de estas comillas va conexion con la base de datos
                optionsBuilder.UseSqlServer("Initial Catalog=Hospital2207208; Data Source=DESKTOP-0LQEFDS\\SQLEXPRESS; Integrated Security=true");
                /*
                    Initial catalog: nombre de la base de datos
                    Data Source: nombre del servidor de la base de datos
                */
            }
        }
    }
}