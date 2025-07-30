using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı girer misin?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for(int i = 0; i <=  sayi; i++)
            {
                toplam += i;

            }
            double ortalama = toplam / sayi;
            if (ortalama > 50)
            {
                Console.WriteLine("ortalamanız 50'den büyük");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ortalamanız 50'den küçük");
                Console.ReadLine();
            }
        }
    }
}
