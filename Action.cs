using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1M2
{
    class Action
    {
        Logger createLog = Logger.GetInstance();
        public void Act1()
        {
            createLog.CreateNewLog( 1, $". Start method:{nameof(Act1)}");
        }
        public void Act2()
        {
            createLog.CreateNewLog( 2, $". Start method:{nameof(Act2)}");
        }
        public void Act3()
        {
            int a = 10;
            const string message = "I broke a toilet";
            try
            {
                a = a/0;
                throw new Exception(message);
            }
            finally
            {

            }
        }
    }
}
