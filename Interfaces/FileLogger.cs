using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class FileLogger:ILogger
    {
        public string WriteLog()
        {
            return "Dosyaya Loglandı.";
        }
    }
}
