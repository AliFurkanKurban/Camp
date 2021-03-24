using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void AddCostumer(Costumer costumer)
        {
            Console.WriteLine(costumer.Name + " " + costumer.Lastname + " "+"eklendi.");
        }

        public void DelCostumer(Costumer costumer)
        {
            Console.WriteLine(costumer.Name + " " + costumer.Lastname + " " + "silindi.");
        }

        public void MakeLists(Costumer costumer)
        {
            Costumer[] costumers = new Costumer[] { costumer };
            Console.WriteLine(costumer.Name + " " + costumer.Lastname + " Listeye eklendi");

            
        }
    }
}
