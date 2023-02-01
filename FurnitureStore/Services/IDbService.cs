using FurnitureStore.Models;

namespace FurnitureStore
{
    public interface IDbService
    {
        List<Product> GetAllProductsByCategory(string name);

        Product GetProductById(int id);

        List<Category> GetAllCategory();

        void AddOrder(Order order);
    }
}
