using Di_Injection.ApplicationService.Communication.Abstract;
using Di_Injection.Core.Entity;

namespace Di_Injection.Data.Repository.Abstracts
{
    public interface IOrderRepository
    {
        void Create(Orders orders);
        bool NotifyTotalExpense(decimal expense, string to, ISenderService senderService);
    }
}
