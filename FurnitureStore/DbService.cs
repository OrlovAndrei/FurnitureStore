using FurnitureStore.Models;

namespace FurnitureStore
{
    public class DbService
    {
        public void AddProdut(Product product)
        {
            using (var db = new ApplicationContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            using (var db = new ApplicationContext())
            {
                products = db.Products.ToList();
            }

            return products;
        }
    }
}
