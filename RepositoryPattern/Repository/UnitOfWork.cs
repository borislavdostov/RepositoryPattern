using RepositoryPattern.IRepository;

namespace RepositoryPattern.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryPatternContext _context;

        public UnitOfWork(RepositoryPatternContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
        }

        public IAuthorRepository Authors { get; }
        public IBookRepository Books { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
