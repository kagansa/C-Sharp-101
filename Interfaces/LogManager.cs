namespace Interfaces
{
    public class LogManager
    {
        private readonly ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public string WriteLog()
        {
            return _logger.WriteLog();
        }
    }
}