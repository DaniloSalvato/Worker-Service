using WorkerService.App.Interface;
using WorkerService.Helper;

namespace WorkerService.App.Service
{
    public class EmailService : IEmail
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public void SendEmail(string to, string subject, string body)
        {
            string password = _config.GetSection("settings").GetSection("Password").Value;
            var outlook = new EmailHelper("smtp.office365.com", "Teste.envia@hotmail.com", password);

            outlook.SendEmail(new List<string> { to }, subject, body);
        }
    }
}
