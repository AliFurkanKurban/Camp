using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCostumer costumer1 = new IndividualCostumer();
            costumer1.FirstName = "Furkan";
            costumer1.LastName = "Kurban";
            costumer1.CostumerNo = "02468";
            costumer1.Id = 1;

            CoorporateCostumer costumer2 = new CoorporateCostumer();
            costumer2.Id = 2;
            costumer2.CompanyName = "Çağrı Ambalaj";
            costumer2.CostumerNo = "13579";
            costumer2.TaxNo = "1234567890";

            Costumer costumer3 = new CoorporateCostumer() ; //Costumer basic olduğundan referans numarası atıyabiliyoruz
            Costumer costumer4 = new IndividualCostumer();


            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer3);

        }
    }
}
