namespace Di_Injection.ApplicationService.Communication.Abstract
{
    public interface ISenderService
    {
        bool Send(string from,string to,string message);
    }
}
