using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public class MacContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Bread> Breads { get; set; }
        public DbSet<Baker> Bakers { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        #region Constructors
        public MacContext()
            : base()
        {
        }

        public MacContext(DbContextOptions options)
            : base(options)
        {
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MacMickDatabase;Integrated Security=true");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}