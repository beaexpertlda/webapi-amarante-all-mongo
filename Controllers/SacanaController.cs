using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_amarante_all.AmaranteManager;

namespace webapi_amarante_all.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SacanaController : Controller
    {
        private SacanaService _sacanaService;

        public SacanaController(SacanaService sacanaService)
        {
            _sacanaService = sacanaService;
        }

        // GET: SacanaController
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _sacanaService.GetAllAsync());
        }




        [HttpPost]
        public async Task<IActionResult> Create(Sacana book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _sacanaService.CreateAsync(book);
            return Ok(book.Id);
        }







    }
}
