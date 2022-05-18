using Ra7ala.Models;
using Microsoft.EntityFrameworkCore;

namespace Ra7ala.data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kharja_sites>().HasKey(am => new
            {
                am.SiteId,
                am.KharjaId
            });

            modelBuilder.Entity<Kharja_sites>().HasOne(m => m.kharja).WithMany(am => am.kharja_Sites).HasForeignKey(m => m.KharjaId);
            modelBuilder.Entity<Kharja_sites>().HasOne(m => m.site).WithMany(am => am.kharja_Sites).HasForeignKey(m => m.SiteId);
          
          


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Kharja> Kharjet { get; set; }
        public DbSet<Kharja_sites> Kharja_Sites { get; set; }
        public DbSet<Organisateur> Organisateurs { get; set; }
        public DbSet<Hotel> Hotels { get; set; }



    }
      
}
