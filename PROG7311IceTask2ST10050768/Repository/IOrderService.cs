using PROG7311IceTask2ST10050768.Models;

namespace PROG7311IceTask2ST10050768.Repository
{
    public interface IOrderService
    {
        string ProcessOrder(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public string ProcessOrder(Order order)
        {
            _orderRepository.SaveOrder(order);
            return $"Order processed. Total Amount: {order.TotalAmount:C}";
        }
    }

}
