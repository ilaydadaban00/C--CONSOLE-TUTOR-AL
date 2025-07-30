using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_59
{
    class Program
    {
        static void Main(string[] args)
        {
            string isimdondurme = Isim("ilayda", "daban");
            Console.WriteLine(isimdondurme);
            Console.ReadLine();
        }
        static int toplama(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        static string Isim(string ad,string Soyad)
        {
            return ad + " " + Soyad;
        }
        

    }
}
