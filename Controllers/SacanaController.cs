using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_amarante_all.AmaranteManager;

namespace webapi_amarante_all.Controllers
{
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

        public ActionResult Index()
        {
            return View();
        }

        // GET: SacanaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SacanaController/Create
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

        // POST: SacanaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SacanaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SacanaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SacanaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SacanaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
