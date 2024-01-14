using Di_Injection.ApplicationService.Controllers;
using Di_Injection.ApplicationService.Provider;
using Di_Injection.Core.Entity;
using Di_Injection.Data.Repository.Abstracts;
using Microsoft.Extensions.DependencyInjection;

#region controller
var services = CustomServiceProvider.CreateServices();
IOrderRepository orderRepository = services.GetRequiredService<IOrderRepository>();
OrderController app = new(orderRepository);
#endregion

Orders orders = new Orders()
{
    ID = 1,
    CreatedBy = "EAKGUL",
    CreatedDate = DateTime.Now,
    Email = "xyz18@gmail.com",
    OrderItems = new List<OrderItems>()
         {
             new OrderItems(){ ID = 1, Order_FKID = 1, Price = 40, Amount = 1, ProductName =  "Süt", Product_ID = 1},
             new OrderItems(){ ID = 2, Order_FKID = 1, Price = 150, Amount = 1, ProductName =  "Yumurta", Product_ID = 16},
             new OrderItems(){ ID = 2, Order_FKID = 1, Price = 450, Amount = 2.3, ProductName =  "Et", Product_ID = 38},
         }
};


#region
if (app.Create(orders))
    app.Notify(orders.Total, orders.Email);
#endregion

Console.ReadLine();