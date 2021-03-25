using System;
using System.Collections.Generic; 

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Furkan","Hasan","Emre","Ali" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names[4] = "Veli";
            //Console.WriteLine(names[4]);
            //Bu şekilde yaparsak hata alırız

            //names = new string[5];
            //names[4] = "Veli";
            //Console.WriteLine(names[4]);
            //Bu şekilde yaparsak hata almayız ama 0 1 2 3 gibi başta kullandığımız değerleri kaybederiz.Bellekte yeni bir veri olarak tutulur
            //Bu yüzden collections lar kullanılır

            List<string> names2 = new List<string> { "Furkan", "Hasan", "Emre", "Ali" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            Console.WriteLine("-----------------------------------------");
            names2.Add("Veli");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
