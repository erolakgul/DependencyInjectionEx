using Di_Injection.Core.Entity;

namespace Di_Injection.Data.Repository.Abstracts
{
    public interface IOrderRepository
    {
        void Create(Orders orders);
    }
}
