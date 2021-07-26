using System;
using RepositoryPattern.Repository;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UnitOfWork(new RepositoryPatternContext()))
            {
                var authors = db.Authors.GetAuthorsPage(0, 10);

                foreach (var author in authors)
                {
                    Console.WriteLine(author.Name);
                }

                Console.WriteLine("------------------------");

                var bestAuthor = db.Authors.GetBestSellingAuthor();

                Console.WriteLine(bestAuthor.Name);
                Console.WriteLine("Books:");

                foreach (var book in bestAuthor.Books)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
    }
}
