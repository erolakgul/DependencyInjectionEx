using Di_Injection.Core.Entity;
using Di_Injection.Data.Repository.Abstracts;

namespace Di_Injection.ApplicationService.Controllers
{
    public class OrderController
    {
        // constructor injection ile repository den nesne alınması
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public string Create(Orders orders)
        {
            _orderRepository.Create(orders);
            return string.Empty;
        }
    }
}
