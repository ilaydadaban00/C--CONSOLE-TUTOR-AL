using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_57
{
    class Program
    {
        static void Main(string[] args)
        {
            toplama(5, 7);
            carpma(5, 7);
            isimsoyisim("ilayda", "daban");
            Console.ReadLine();
        }

        static void toplama(int sayi1,int sayi2)
        {
            Console.WriteLine("gönderilen sayıların toplamı   " + (sayi1 + sayi2));
              
        }


        static void carpma(int sayi1,int sayi2)
        {
            Console.WriteLine("gönderilen değerlerin çarpımı " + (sayi1 * sayi2));
        }
        static void isimsoyisim(string deger1,string deger2)
        {
            Console.WriteLine("  isim ve soyisim  " + deger1 + "  " + deger2);
        }
    }
}
