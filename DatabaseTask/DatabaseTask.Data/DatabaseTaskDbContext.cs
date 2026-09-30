using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Prison> Prisons { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Prisoner> Prisoners { get; set; }
        public DbSet<Crime> Crimes { get; set; }
    }
}
