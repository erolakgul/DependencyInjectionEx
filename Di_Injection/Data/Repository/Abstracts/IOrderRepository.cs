using Di_Injection.ApplicationService.Cache.Abstract;
using Di_Injection.Core.Entity;

namespace Di_Injection.Data.Repository.Abstracts
{
    public interface IOrderRepository
    {
        // property injection
        ICacheService cacheService { get; set; }
        void Create(Orders orders);
    }
}
