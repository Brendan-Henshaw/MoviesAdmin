using System;

namespace MoviesAdmin.Models
{
	public class Movie
	{
		public int ID { get; set; };

		public string Title { get; set; } = string.Empty;

		public string Synopsis { get; set; } = string.Empty;

		public string Genre { get; set; } = string.Empty;

		public string Director { get; set; } = string.Empty;

		public TimeSpan RunTime { get; set; };

		public DateTime ReleaseDate { get; set; };
	}
}