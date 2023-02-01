namespace FurnitureStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal OrderPrice { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
        public string Adress { get; set; }
    }
}
