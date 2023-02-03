using FurnitureStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore
{
    public class DbService : IDbService
    {
        public List<Product> GetAllProductsByCategory(string name)
        {
            var products = new List<Product>();

            using (var db = new ApplicationContext())
            {
				//products = db.Products.Where(p => db.Categories.Where(c => c.Name == name).FirstOrDefault().Id == p.CategoryId).ToList();
				products = db.Products.Where(p => p.Category.Name == name).ToList();
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
                var g = db.Orders.ToList();
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }
    }
}
