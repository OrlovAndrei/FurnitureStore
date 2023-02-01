using FurnitureStore.Models;

namespace FurnitureStore
{
    public interface IDbService
    {
        List<Product> GetAllProductsByCategoryId(int id);

        Product GetProductById(int id);

        List<Category> GetAllCategory();

        void AddOrder(Order order);
    }
}
