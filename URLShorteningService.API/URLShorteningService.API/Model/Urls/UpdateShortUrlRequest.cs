using System.ComponentModel.DataAnnotations;

namespace URLShorteningService.API.Model.Urls
{
    // PUT /shorten/{shortCode}
    public class UpdateShortUrlRequest
    {
        [Required]
        [MaxLength(2048)]
        [Url]
        public string Url { get; set; } = string.Empty;
    }
}
