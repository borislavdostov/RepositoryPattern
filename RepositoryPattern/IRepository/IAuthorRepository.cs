using System.Collections.Generic;
using RepositoryPattern.Model;

namespace RepositoryPattern.IRepository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetBestSellingAuthor();
        IEnumerable<Author> GetAuthorsPage(int pageIndex, int pageSize);
    }
}
