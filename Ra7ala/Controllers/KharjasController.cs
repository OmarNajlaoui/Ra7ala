using Ra7ala.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ra7ala.data;

namespace Ra7ala.Controllers
{
    public class KharjasController : Controller
    {
        private readonly AppDbContext _context;
        public KharjasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allKahrjas = await _context.Kharjet.Include(o=>o.Organisateur).OrderBy(d=>d.StartDate).ToListAsync();
            return View(allKahrjas);
        }
    }
}
