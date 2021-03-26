using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager//Başvuru Manager
    {
        public void MakeApp(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void CreditPriorKnowledge(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
