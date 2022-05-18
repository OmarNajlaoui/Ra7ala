using Ra7ala.Models;

namespace Ra7ala.data.Services
{
    public interface ISitesService
    {
        Task<IEnumerable<Site>> GetAllAsync();
       Task<Site> GetByIdAsync(int id);   
        Task AddAsync(Site site);
       Task<Site> UpdateAsync(int id, Site newSite);
        Task DeleteAsync(int id);    
    }
}
