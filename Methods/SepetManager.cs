using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);

        }
    
        public void Ekle2(string urunAdi , int urunfiyati)
        {
            Console.WriteLine("Sepete eklendi : " +urunAdi);
            Console.WriteLine("Sepete eklendi : " + urunfiyati);
        }
    }

}
