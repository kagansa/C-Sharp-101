namespace Interfaces
{
    public class SmsLogger : ILogger
    {
        public string WriteLog()
        {
            return "Sms Olarak Loglandı.";
        }
    }
}