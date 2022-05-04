using Microsoft.EntityFrameworkCore;
using RenoMeraApi.Domain.Models;

namespace RenoMeraApi.Persistence
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<ConstructionPost> constructionPosts { get; set; }
        public DbSet<CustomerPost> customerPosts { get; set; }
        public DbSet<SupplierPost> supplierPosts { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SupplierPost>().HasData(new SupplierPost
            {
                SupplierPostId = 1,
                title = "Buy now at half the price",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "https://www.lassesiryd.se/pub_images/large/700405.jpg",
                City = "Linköping",
                Price = 75,
                Phone = "0739888159"
            
    });
            modelBuilder.Entity<SupplierPost>().HasData(new SupplierPost
            {
                SupplierPostId = 2,
                title = "Amazing second hand building tools",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "https://th.bing.com/th/id/OIP.C0Y25ccnnRv-KsXdfFXIeAAAAA?pid=ImgDet&rs=1",
                City = "Linköping",
                Price = 99,
                Phone = "0739888159"

            });

            modelBuilder.Entity<CustomerPost>().HasData(new CustomerPost
            {
                CustomerPostId = 1,
                Title = "Need Help with my old house wall",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                City = "Linköping",
                Image = "https://get.pxhere.com/photo/wood-house-texture-window-old-wall-rural-abandoned-empty-brick-lumber-door-weathered-dilapidated-wooden-aged-urban-area-1380478.jpg",
                PhoneNumber = "0739888159"
       

    });
            modelBuilder.Entity<CustomerPost>().HasData(new CustomerPost
            {
                CustomerPostId = 2,
                Title = "Need Help with this door",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                City = "Linköping",
                Image = "https://www.house-extension.co.uk/wp-content/uploads/2016/02/old-door-683x1024.jpg",
                PhoneNumber = "0739888159"


            });


            modelBuilder.Entity<ConstructionPost>().HasData(new ConstructionPost
            {

                ConstructionPostId = 1,
                title = "Looking for tools",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "https://www.house-extension.co.uk/wp-content/uploads/2016/02/old-door-683x1024.jpg",
                Phone = "0739888159"

            });

            modelBuilder.Entity<ConstructionPost>().HasData(new ConstructionPost
            {

                ConstructionPostId = 2,
                title = "Looking for these hammers",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "https://www.cornwallbuildingsupplies.com/wp-content/uploads/2020/08/tools-01.jpg",
                Phone = "0739888159"

            });
        }

    }
}
