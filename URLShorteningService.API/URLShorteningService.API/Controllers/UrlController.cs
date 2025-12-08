using Microsoft.AspNetCore.Mvc;
using URLShorteningService.API.Model.Entities;
using URLShorteningService.API.Model.Urls;

namespace URLShorteningService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UrlController(ApplicationDbContext context)
        {
            _context = context;
        }

        private static UrlResponseDto MaptoUrlDto(Url entity) => new UrlResponseDto()
        {
                Id = entity.Id,
                Url = entity.OriginalUrl,
                ShortCode = entity.ShortCode,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                AccessCount = entity.TimesAccessed
        };
    }
}
