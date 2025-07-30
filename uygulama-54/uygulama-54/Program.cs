using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40,40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 80 };

            int adet = 0;

            Console.WriteLine("sayı girer misin");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("girdiğiniz değer bulunamadı");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayi dizide bulundu...");
                Console.WriteLine("adet" + adet);
            }
            Console.ReadLine();
        }
    }
}
