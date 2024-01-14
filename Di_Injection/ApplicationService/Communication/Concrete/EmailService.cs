using Di_Injection.ApplicationService.Communication.Abstract;

namespace Di_Injection.ApplicationService.Communication.Concrete
{
    public class EmailService : ISenderService
    {
        public bool Send(string from,string to, string message)
        {
            Console.WriteLine($"\n\nEmail was sent to {to} by {from} with message :\n {message}");
            return true;
        }
    }
}
