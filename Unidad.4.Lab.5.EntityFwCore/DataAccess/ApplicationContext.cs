using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    // Crear las propiedades DbSet (las cuales representan tablas en la db) 
    // para cada entidad del dominio (Materia, Planes y Especialidades).
    // Luego crear constructor que tome DbContextOptions<ApplicationContext>
    // como parametro y lo envié al constructor de la clase padre DbContext
    public class ApplicationContext : DbContext
    {
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> contextOptions) : base(contextOptions) { }
    }
}