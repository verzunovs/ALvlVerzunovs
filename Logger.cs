using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
