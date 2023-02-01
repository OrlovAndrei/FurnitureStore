using FurnitureStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore
{
    public class DbService
    {
        public List<Product> GetAllProductsByCategoryId(int id)
        {
            var products = new List<Product>();

            using (var db = new ApplicationContext())
            {
                products = db.Products.Include(p => p.Category).Where(c => c.Id == id).ToList();
            }

            return products;
        }

        public Product GetProductById(int id)
        {
            var product = new Product();

            using (var db = new ApplicationContext())
            {
                product = db.Products.Where(p => p.Id == id).FirstOrDefault();
            }

            return product;
        }

        public List<Category> GetAllCategory()
        {
            var categories = new List<Category>();

            using (var db = new ApplicationContext())
            {
                categories = db.Categories.ToList();
            }

            return categories;
        }

        public void AddOrder(Order order)
        {
            using (var db = new ApplicationContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }
    }
}
