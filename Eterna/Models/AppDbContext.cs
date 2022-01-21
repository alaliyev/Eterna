using Eterna.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Models
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
         public DbSet<Slider> Sliders { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet <Portfolio> Portfolios { get; set; }

        public DbSet<PortfolioImage> PortfolioImages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Logo> Logos { get; set; }



    }
}
