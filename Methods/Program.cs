using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma" ;
            urun1.Fiyati = 15 ;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 65;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2};

            foreach (Product urunun in urunler) 
            {
                Console.WriteLine("Ürünün Adı : " + urunun.Adi) ;
                Console.WriteLine("Ürünün Fiyatı : " + urunun.Fiyati);
                Console.WriteLine(urunun.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("___________________Metotlar_______________________");

            SepetManager sepetManager = new SepetManager() ;
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("__________________________________");
            //Yanlış kullanım 
            sepetManager.Ekle2("Ayva", 20);


        }
    }
}
