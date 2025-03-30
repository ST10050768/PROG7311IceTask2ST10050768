namespace PROG7311IceTask2ST10050768.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new();
        public decimal TotalAmount => Products.Sum(p => p.Price);
    }
}
