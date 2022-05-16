namespace Afslutningsprojekt.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /*seeding datatables/models*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                
            new Product
            {
                Id = 1,
                Title = "testing T-shirt flag 1",
                Price = 100,
                OriginalPrice = 200,
                Description = "Unikum Munikums first t-shirt design to be introduced to the website",
                Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg",
                CategoryId = 1,
            },
            new Product
            {
                Id = 2,
                Title = "testing T-shirt 2",
                Price = 99,
                OriginalPrice = 200,
                Description = "Unikum Munikums second t-shirt design to be introduced to the website",
                Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg",
                CategoryId = 1,
            },
            new Product
            {
                Id = 3,
                Title = "testing T-shirt 2",
                Price = 99,
                OriginalPrice = 200,
                Description = "Unikum Munikums ordinary shirt",
                Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg",
                CategoryId = 1,
            },
            new Product
            {
                Id = 4,
                Title = "testing T-shirt",
                Price = 99,
                OriginalPrice = 200,
                Description = "Unikum Munikums second t-shirt design to be introduced to the website",
                Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg",
                CategoryId = 1,
            },
            new Product
            {
                Id = 5,
                Title = "ugly testing T-shirt",
                Price = 99,
                OriginalPrice = 200,
                Description = "Unikum Munikums second t-shirt design to be introduced to the website",
                Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg",
                CategoryId = 1,
            }
                );
        }

        /*Creates a database table of products
         Add more models here, if you want more tables in the database*/
        public DbSet<Product> Products { get; set; }
    }
}
