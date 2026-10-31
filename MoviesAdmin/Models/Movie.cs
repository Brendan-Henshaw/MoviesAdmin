using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesAdmin.Models
{
	public class Movie
	{
		public int ID { get; set; }

		[Required]
		public string Title { get; set; } = string.Empty;

        [Required]
        public string Synopsis { get; set; } = string.Empty;

        // FOREIGN KEY
        [Display(Name = "Genre")]
        public int GenreID { get; set; }

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        // FOREIGN KEY
        [Display(Name = "Rating")]
        public int AudienceRatingID {  get; set; }

        [ValidateNever]
        public AudienceRating AudienceRating { get; set; } = null!;

        // FOREIGN KEY
        [Display(Name = "Director")]
        public int DirectorID { get; set; }

        [ValidateNever]
        public Director Director { get; set; } = null!;

        [Display(Name = "Run Time (Minutes)")]
        [Required]
        public int RunTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM d, yyyy}")]
        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        public string ImageUrl { get; set; } = string.Empty;
	}
}