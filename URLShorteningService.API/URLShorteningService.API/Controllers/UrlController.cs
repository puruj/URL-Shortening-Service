using Microsoft.AspNetCore.Mvc;

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
    }
}
