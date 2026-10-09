using System.ComponentModel.DataAnnotations;

namespace MoviesAdmin.Models
{
    public class CriticReview
    {
        public int ID { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Range(1, 5, ErrorMessage = "Ratings must be 1-5 Stars")]
        [Required]
        public int Rating { get; set; }

        [Required]
        public bool IsPublished { get; set; }

        [Required]
        public string CreatedBy { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
