using JuanProject.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        public override int SaveChanges()
        {
            var data = ChangeTracker.Entries<Comment>();
            foreach (var item in data)
            {
                switch (item.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        //item.Entity.DeletedAt= DateTime.Now;
                        break;
                    case EntityState.Modified:
                        //item.Entity.UpdateDate= DateTime.Now;
                        break;
                    case EntityState.Added:
                        item.Entity.CreatedDate= DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChanges();
        }
    }
}
