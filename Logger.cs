using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Hw1M2
{
    class Logger
    {
        private static Logger instance;
        StringBuilder log = new StringBuilder();
        private Logger() { }
        public static Logger GetInstance()
        {
            if (instance == null) instance = new Logger();
            return instance;
        }
        public enum TypeOfLogMessage
        {
            Info = 1,
            Warning = 2,
            Error = 404
        }

        public void CreateNewLog(int logMessage, string message)
        {
            switch (logMessage)
            {
                case (int)TypeOfLogMessage.Info:
                    log.Append($"{TypeOfLogMessage.Info}:{message}.\n");
                    break;
                case (int)TypeOfLogMessage.Warning:
                    log.Append($"{TypeOfLogMessage.Warning}:{message}.\n");
                    break;
                case (int)TypeOfLogMessage.Error:
                    log.Append($"{TypeOfLogMessage.Error}:{message}.\n");
                    break;
            }

            Console.Write(log);
        }
    }
}
