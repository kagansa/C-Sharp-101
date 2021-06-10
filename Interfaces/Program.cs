using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager logManager = new LogManager(new DatabaseLogger());
            Console.WriteLine(logManager.WriteLog());

            logManager = new LogManager(new FileLogger());
            Console.WriteLine(logManager.WriteLog());

            logManager = new LogManager(new SmsLogger());
            Console.WriteLine(logManager.WriteLog());
        }
    }
}
