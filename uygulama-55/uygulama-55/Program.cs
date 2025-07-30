using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_55
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int tekadetToplam = 0;
            int ciftAdetToplam = 0;

            int teksayilartToplam = 0;
            int ciftsayilartoplam = 0;

            int kullanicideger;


            for(int i = 0; i< sayilar.Length; i++)
            {
                Console.Write((i+0)+"index değerini giriniz:");
                kullanicideger = int.Parse(Console.ReadLine());
                sayilar[i] = kullanicideger;

            }


             for(int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j]% 2== 0)
                {
                    ciftAdetToplam++;
                    ciftsayilartoplam += sayilar[j];
                }
                else
                {
                    tekadetToplam++;
                    teksayilartToplam += sayilar[j];
                }
            }
            if (ciftsayilartoplam > teksayilartToplam)
            {
                Console.WriteLine("çift sayıların toplamı tek sayıların toplamından buyukur");
            }
            else
            {
                Console.WriteLine("tek sayıların toplamı çift sayıların toplamından buyuktur");
            }

            Console.WriteLine("*************************");

            Console.WriteLine("çift sayıların toplamı " + ciftsayilartoplam);
            Console.WriteLine("çift sayıların adedi " + ciftAdetToplam);




            Console.WriteLine("*************************");

            Console.WriteLine("tek sayıların toplamı " + teksayilartToplam);
            Console.WriteLine("çift sayıların adedi " + ciftAdetToplam);

            Console.ReadLine();
        }

    }
}
