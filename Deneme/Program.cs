using Methods;
using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Console.WriteLine(urun1);
            Console.ReadLine();

            
        
        }
    }
}
