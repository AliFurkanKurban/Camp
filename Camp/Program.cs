using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("*************************** for bitti **********************************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Product urun1 = new Product();
            urun1.urunAdi = "Ayakkabı";
            urun1.urunTipi = "Bot";
            urun1.urunFiyati = 180;

            Product urun2 = new Product();
            urun2.urunAdi = "Pantolon";
            urun2.urunTipi = "Kot";
            urun2.urunFiyati = 70;

            Product urun3 = new Product();
            urun3.urunAdi = "Bilgisayar";
            urun3.urunTipi = "Dizüstü";
            urun3.urunFiyati = 4500;

            Product[] urunler = new Product[] { urun1, urun2, urun3 };
            Console.WriteLine("***********************for için***************************\n\n");
            for (int i = 0; i < urunler.Length; i += 1)
            {
                Console.WriteLine(urunler[i].urunAdi + " " + urunler[i].urunTipi + " " + urunler[i].urunFiyati);

            }

            Console.WriteLine("***********************foreach için***********************\n\n");
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " " + urun.urunTipi + " " + urun.urunFiyati);

            }

            Console.WriteLine("***********************while için***********************\n\n");
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].urunAdi + " " + urunler[j].urunTipi + " " + urunler[j].urunFiyati);
                j++;
            }


        }
    }

    class Product
    {
        public string urunAdi { get; set; }
        public string urunTipi { get; set; }
        public int urunFiyati { get; set; }


    }




}
