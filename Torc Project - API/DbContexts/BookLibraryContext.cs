using Microsoft.EntityFrameworkCore;

namespace Torc_Project___API.DbContexts
{
    public class BookLibraryContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("###");
        }
    }
}
