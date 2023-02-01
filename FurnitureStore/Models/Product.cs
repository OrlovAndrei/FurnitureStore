using System.ComponentModel;

namespace FurnitureStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
