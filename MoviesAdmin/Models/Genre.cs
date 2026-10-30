using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MoviesAdmin.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [ValidateNever]
        public List<Movie> Movies { get; set; } = new List<Movie>();

        [Required]
        public string Title { get; set; } = string.Empty;
    }
}
