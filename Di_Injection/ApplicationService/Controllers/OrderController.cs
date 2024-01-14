using Di_Injection.ApplicationService.Communication.Concrete;
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

        public bool Create(Orders orders)
        {
            _orderRepository.Create(orders);
            return true;
        }

        // method injection ile ISenderService in gönderilmesi
        public void Notify(decimal total, string email)
        {
            _orderRepository.NotifyTotalExpense(total, email, new EmailService());
        }
    }
}
