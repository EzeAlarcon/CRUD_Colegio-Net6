using Microsoft.EntityFrameworkCore;

namespace CRUD_Colegio.Models
{
    public class ColegioContext : DbContext
    {
        // Constructor que toma las opciones del contexto proporcionadas por el servicio de inyección de dependencias
        public ColegioContext(DbContextOptions<ColegioContext> options) : base(options)
        {
        }

        // DbSet que representa la tabla de estudiantes en la base de datos
        public DbSet<Colegio> Colegio { get; set; }

        // Método que se llama al crear el modelo de la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Llama al método base para mantener el comportamiento predeterminado
            base.OnModelCreating(modelBuilder);

            // Configuración adicional del modelo, en este caso, se agrega un índice único a la propiedad "Name" de la entidad "Estudiantes"
            modelBuilder.Entity<Colegio>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
