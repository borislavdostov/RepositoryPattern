using System.Collections.Generic;
using RepositoryPattern.Model;

namespace RepositoryPattern.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBestSellerBook();
        IEnumerable<Book> GetMostExpensiveBooks(int count);
    }
}
