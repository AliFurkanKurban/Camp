using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Costumer costumer1 = new Costumer();
            costumer1.Name = "Ali";
            costumer1.Lastname = "Kurban";
            costumer1.Id = 12345;


            Costumer costumer2 = new Costumer();
            costumer2.Name = "Furkan";
            costumer2.Lastname = "Kurban";
            costumer2.Id = 67890;

            CostumerManager costumermanager = new CostumerManager();
            costumermanager.AddCostumer(costumer1);
            costumermanager.MakeLists(costumer1);
            costumermanager.DelCostumer(costumer1);
    
            Console.WriteLine("________________________________________");
            costumermanager.AddCostumer(costumer2);
            costumermanager.MakeLists(costumer2);
            costumermanager.DelCostumer(costumer2);
            



        }
    }
}
