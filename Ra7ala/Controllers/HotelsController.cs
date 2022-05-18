using Ra7ala.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ra7ala.data;

namespace Ra7ala.Controllers
{
    public class HotelsController : Controller
    {
        private readonly AppDbContext _context;
        public HotelsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allHotels = await _context.Hotels.ToListAsync();
            return View(allHotels);
        }
    }
}
