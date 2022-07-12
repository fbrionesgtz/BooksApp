using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BooksApp.ViewModels
{
    public class BookViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter an author")]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter a year published")]
        public int YearPublished { get; set; }

        [Display(Name = "Book Image")]
        public IFormFile Image { get; set; }
    }
}