using Microsoft.EntityFrameworkCore;
using Ra7ala.Models;

namespace Ra7ala.data.Services
{
    public class SitesServices : ISitesService
    {
        private readonly AppDbContext _context;
        public SitesServices(AppDbContext  context)
        {
            _context = context; 
        }
        public async Task AddAsync(Site site)
        {
          await _context.Sites.AddAsync(site);    
            await _context.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int id)
        {
            var rslt = await _context.Sites.FirstOrDefaultAsync(s => s.Id == id);
             _context.Sites.Remove(rslt);
            await _context.SaveChangesAsync();  
        }

        public async Task<IEnumerable<Site>> GetAllAsync()
        {
            var reslut =  await _context.Sites.ToListAsync();
            return reslut;
        }

        public async Task<Site> GetByIdAsync(int id)
        {
            var rslt = await _context.Sites.FirstOrDefaultAsync(s=> s.Id == id);
            return rslt;
        }

        public async Task<Site> UpdateAsync(int id, Site newSite)
        {
           _context.Update(newSite);
            await _context.SaveChangesAsync();
            return newSite;
        }
    }
}
