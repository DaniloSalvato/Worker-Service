namespace WorkerService.App.Interface
{
    public interface IEmail
    {
        void SendEmail(string to, string subject, string body);
    }
}
