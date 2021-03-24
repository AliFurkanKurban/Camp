using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Ali Furkan Kurban";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 78;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.KursAdi = "Python";
            kurs2.IzlenmeOrani = 56;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (Kurs x in kurslar)
            {
                Console.WriteLine(x.Egitmen + " " + x.KursAdi + " İzlenme Oranı : " + x.IzlenmeOrani);
            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }





}
