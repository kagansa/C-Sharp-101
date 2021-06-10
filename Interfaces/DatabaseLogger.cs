namespace Interfaces
{
    public class DatabaseLogger:ILogger
    {
        public string WriteLog()
        {
            return "Veritabanına Loglandı.";
        }
    }
}