using Di_Injection.Core.Entity;
using Di_Injection.Data.Repository.Abstracts;

namespace Di_Injection.Data.Repository.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        public void Create(Orders orders)
        {
            Console.WriteLine($"Order has been saved successfully..\n");

            Console.WriteLine($"{orders.ID} numbered Order Summary :");
            Console.WriteLine("----------------------------");
            foreach (var order in orders.OrderItems)
            {
                Console.WriteLine($"{order.Amount} amount {order.ProductName}");
            }
        }
    }
}
