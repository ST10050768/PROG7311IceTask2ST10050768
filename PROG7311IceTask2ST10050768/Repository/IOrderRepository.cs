using PROG7311IceTask2ST10050768.Models;

namespace PROG7311IceTask2ST10050768.Repository
{
    public interface IOrderRepository
    {
        void SaveOrder(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public void SaveOrder(Order order)
        {
            // Mock saving order (no database, just a console message)
            Console.WriteLine($"Order with {order.Products.Count} products saved successfully.");
        }
    }
}
