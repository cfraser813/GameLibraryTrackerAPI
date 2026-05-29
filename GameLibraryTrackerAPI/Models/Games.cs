namespace GameLibraryTrackerAPI.Models
{
    public class Games
    {
        public int ID { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Platform { get; set; } = null!;
        public int ReleaseYear { get; set; }
    }
}