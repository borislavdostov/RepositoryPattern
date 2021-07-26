using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Model
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
