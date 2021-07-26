using System.Data.Entity;
using RepositoryPattern.Model;

namespace RepositoryPattern
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext() : base("name=RepositoryPatternContext")
        {
            
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
