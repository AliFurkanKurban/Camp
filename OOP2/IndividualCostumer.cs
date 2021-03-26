using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCostumer:Costumer   //Bireysel Müşteri //Burada ':' ile yaptığımız işlemin adı İnhalitance
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCKN { get; set; }

    }
}
