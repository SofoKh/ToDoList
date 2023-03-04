
using Microsoft.EntityFrameworkCore;
using ToDoList.DataBase.Entity;

namespace ToDoList.DataBase.Context
{
    public partial class NoteDBContext : DbContext
    {
        public NoteDBContext()
        {
        }

        public NoteDBContext(DbContextOptions<NoteDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Note> NoteList { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public virtual DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("Server = (local); Database = ToDoList; Trusted_Connection = True; ");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
