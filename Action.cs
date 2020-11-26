using System;

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
            Random rndError = new Random();
            int div = rndError.Next(0, 2);
            try
            {
                a = a/div;
                throw new Exception(message);
            }
            finally
            {

            }
        }
    }
}
