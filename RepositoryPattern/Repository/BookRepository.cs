using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RepositoryPattern.IRepository;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public RepositoryPatternContext RepositoryPatternContext => Context as RepositoryPatternContext;

        public BookRepository(DbContext context) : base(context)
        {
        }

        public Book GetBestSellerBook()
        {
            return RepositoryPatternContext.Books.FirstOrDefault();
        }

        public IEnumerable<Book> GetMostExpensiveBooks(int count)
        {
            return RepositoryPatternContext.Books.OrderByDescending(b => b.Title).Take(count);
        }
    }
}
