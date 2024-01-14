using Di_Injection.Data.Repository.Abstracts;
using Di_Injection.Data.Repository.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Di_Injection.ApplicationService.Provider
{
    public static class CustomServiceProvider
    {
        public static ServiceProvider CreateServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IOrderRepository, OrderRepository>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
