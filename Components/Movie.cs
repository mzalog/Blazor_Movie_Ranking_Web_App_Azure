using System.ComponentModel.DataAnnotations;

namespace MovieRankingBlazor.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float? Rate { get; set; }
        public string? ImageUrl { get; set; }
        public int NumberOfReviews { get; set; }
        public byte[]? ImageData { get; set; }
        public string? FilePath { get; set; }
    }
}
