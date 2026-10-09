using System.ComponentModel.DataAnnotations;

namespace MoviesAdmin.Models
{
    public class AudienceRating
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
    }
}
