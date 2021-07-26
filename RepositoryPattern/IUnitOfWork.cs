using System;
using RepositoryPattern.IRepository;

namespace RepositoryPattern
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        int Complete();
    }
}
