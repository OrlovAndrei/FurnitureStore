namespace FurnitureStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal OrderPrice { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
        public string Address { get; set; }
    }
}
