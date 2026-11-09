using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MoviesAdmin.Models
{
    public class CriticReview
    {
        public int ID { get; set; }

        [Display(Name = "Movie")]
        public int MovieID { get; set; }

        [ValidateNever]
        [ScaffoldColumn(false)]
        public Movie Movie { get; set; } = null!;

        [Required]
        [StringLength(1000, ErrorMessage = "Must be under 1000 characters.")]
        public string Description { get; set; } = string.Empty;

        [Range(1, 5, ErrorMessage = "Ratings must be 1-5 Stars")]
        [Required]
        public int Rating { get; set; }

        [Required]
        public bool IsPublished { get; set; }

        [Required]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
