using System;

namespace Hw1M2
{
    class Starter
    {
        Action functionsCall = new Action();
        Logger createLog = Logger.GetInstance();
        public void Run()
        {
            Random rndFeunctionChooser = new Random();
            for (int i = 0; i < 100; i++)
            {
                int functionChooser = rndFeunctionChooser.Next(0, 4);
                try
                {
                    switch (functionChooser)
                    {
                        case 1:
                            functionsCall.Act1();
                            break;
                        case 2:
                            functionsCall.Act2();
                            break;
                        case 3:
                            functionsCall.Act3();
                            break;
                    }
                }
                catch(Exception e)
                {
                    createLog.CreateNewLog(404, $"Action failed by reason:{e.StackTrace}");
                }
            }
                    createLog.WriteToFile();
        }
    }
}
