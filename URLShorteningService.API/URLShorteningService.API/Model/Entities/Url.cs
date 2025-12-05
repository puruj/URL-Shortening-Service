namespace URLShorteningService.API.Model.Entities
{
    public class Url
    {
        public Guid Id { get; set; }
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortCode { get; set; } = string.Empty;
        public int TimesAccessed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
