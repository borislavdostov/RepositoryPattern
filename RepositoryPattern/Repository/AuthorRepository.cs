using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RepositoryPattern.IRepository;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public RepositoryPatternContext RepositoryPatternContext => Context as RepositoryPatternContext;

        public AuthorRepository(DbContext context) : base(context)
        {
        }

        public Author GetBestSellingAuthor()
        {
            return RepositoryPatternContext.Authors.Include(a=>a.Books).OrderBy(a => a.Name).FirstOrDefault();
        }

        public IEnumerable<Author> GetAuthorsPage(int pageIndex, int pageSize)
        {
            return RepositoryPatternContext.Authors.OrderBy(a=>a.Name).Skip(pageIndex).Take(pageSize);
        }
    }
}
