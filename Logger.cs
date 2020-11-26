using System;
using System.Text;
using System.IO;
namespace Hw1M2
{
    class Logger
    {
        private static Logger instance;
        StringBuilder logList = new StringBuilder();
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
            StringBuilder log = new StringBuilder();
            switch (logMessage)
            {
                case (int)TypeOfLogMessage.Info:
                    log.Append($"{TypeOfLogMessage.Info}:{message}.\n");
                    logList.Append(log);
                    break;
                case (int)TypeOfLogMessage.Warning:
                    log.Append($"{TypeOfLogMessage.Warning}:{message}.\n");
                    logList.Append(log);
                    break;
                case (int)TypeOfLogMessage.Error:
                    log.Append($"{TypeOfLogMessage.Error}:{message}.\n");
                    logList.Append(log);
                    break;
            }
            Console.Write(log);
        }
        public void WriteToFile()
        {
            File.WriteAllText("output.txt",logList.ToString());
        }  
        }
}
