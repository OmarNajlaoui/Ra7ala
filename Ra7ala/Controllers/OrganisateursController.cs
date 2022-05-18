using Ra7ala.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ra7ala.data;

namespace Ra7ala.Controllers
{
    public class OrganisateursController : Controller
    {
        private readonly AppDbContext _context;
        public OrganisateursController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allOrganisateur = await _context.Organisateurs.ToListAsync();
            return View(allOrganisateur);
        }
    }
}
