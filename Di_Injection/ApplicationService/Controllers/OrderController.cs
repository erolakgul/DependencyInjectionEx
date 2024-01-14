using Di_Injection.ApplicationService.Cache.Concrete;
using Di_Injection.Core.Entity;
using Di_Injection.Data.Repository.Abstracts;
using Di_Injection.Data.Repository.Concrete;

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
            // property injection ın register aşaması
            _orderRepository.cacheService = new CacheService();

            _orderRepository.Create(orders);
            return string.Empty;
        }
    }
}
