namespace URLShorteningService.API.Model.Urls
{
    // Response for GET/POST/PUT (and base for stats)
    public class UrlResponseDto
    {
        public Guid Id { get; set; }

        // This will be the original long URL
        public string Url { get; set; } = string.Empty;

        public string ShortCode { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        // For stats endpoint you can use this as "accessCount"
        public int AccessCount { get; set; }
    }
}
