using Microsoft.EntityFrameworkCore;
using NextFurniture.Models.DAL.Entities;

namespace NextFurniture.Models.DAL.Context
{
    public class NextFurnitureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E7MGKIP;initial Catalog=NFDB;integrated Security=true;");
        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<WhyUs> WhyUss { get; set; }
    }
}
