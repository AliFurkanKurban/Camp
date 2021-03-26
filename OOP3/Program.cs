using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); // *1*
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            AppealManager appealManager = new AppealManager();
            
            List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService,smsLoggerService };
            
            appealManager.MakeApp(mortgageLoanManager, loggers); 
            //appealManager.MakeApp(mortgageLoanManager, new DatabaseLoggerService()); bu şekildede yapılabilir *1* işaret, olan satır kullanılmadan 

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,transportCreditManager };
            //appealManager.CreditPriorKnowledge(credits);


        }
    }
}
