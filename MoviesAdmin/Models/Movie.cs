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

        [Required]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public string Director { get; set; } = string.Empty;

        [Display(Name = "Run Time (Minutes)")]
        [Required]
        public int RunTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM d, yyyy}")]
        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
	}
}