using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> sozluk = new MyDictionary<string, string>();
            sozluk.Add("car", "araba");
            sozluk.Add("flower", "çiçek");
            sozluk.Add("dog", "köpek");

            sozluk.ShowMe();
        }
    }
}
