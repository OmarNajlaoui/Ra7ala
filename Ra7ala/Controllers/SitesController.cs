
using Microsoft.AspNetCore.Mvc;
using Ra7ala.data;
using Ra7ala.data.Services;
using Ra7ala.Models;

namespace Ra7ala.Controllers
{
    
    public class SitesController : Controller
    {

        private readonly ISitesService ser;
        public SitesController(ISitesService servive)
        {
            ser = servive;
        }

            public async Task<IActionResult> Index()
        {
            var data = await ser.GetAllAsync();
            return View(data);  
        }
        public  IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ImageUrl,Name,Adresse,Desc")]Site site)
        {
            if (ModelState.IsValid)
            {
                return View(site);
            }
            await ser.AddAsync(site);
            return RedirectToAction(nameof(Index));

        } 
        public async Task<IActionResult> Details(int id)
        {
            var siteDeitails = await ser.GetByIdAsync(id);
            if (siteDeitails == null) return View("404");
            {
                return View(siteDeitails);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var siteDeitails = await ser.GetByIdAsync(id);
            if (siteDeitails == null) return View("404");
            {
                return View(siteDeitails);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageUrl,Name,Adresse,Desc")] Site site)
        {
            if (ModelState.IsValid)
            {
                return View(site);
            }
            await ser.UpdateAsync(id, site);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var siteDeitails = await ser.GetByIdAsync(id);
            if (siteDeitails == null) return View("404");
            {
                return View(siteDeitails);
            }
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siteDeitails = await ser.GetByIdAsync(id);
            if (siteDeitails == null) return View("404");
            await ser.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }

    }
    }