using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Model
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        public Author Author { get; set; }
    }
}
