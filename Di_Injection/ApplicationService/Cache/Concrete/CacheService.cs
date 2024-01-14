using Di_Injection.ApplicationService.Cache.Abstract;

namespace Di_Injection.ApplicationService.Cache.Concrete
{
    public class CacheService : ICacheService
    {
        public bool SetCacheName(string name)
        {
            Console.WriteLine($"\n{name} object was cached..");
            return true;
        }
    }
}
