using System.ComponentModel.DataAnnotations;

namespace URLShorteningService.API.Model.Urls
{
    public class CreateShortUrlRequest
    {
        [Required]
        [MaxLength(2048)]
        [Url]
        public string Url { get; set; } = string.Empty;
    }
}
