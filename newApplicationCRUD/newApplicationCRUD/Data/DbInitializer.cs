using newApplicationCRUD.Models;
using System.Linq;
namespace newApplicationCRUD.Data
{
    public class DbInitializer
    {

        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Products[]
            {
                new Products { Name = "Apple", Price = 40, Quantity = 10 },
                new Products { Name = "Mango", Price = 50, Quantity = 20 },
            };

            foreach (var p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }
    }
}
