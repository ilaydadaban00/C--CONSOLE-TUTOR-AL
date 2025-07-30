using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı1 girer misin");
            int sayi1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("sayı2 girer misin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            buyuk(sayi1, sayi2);
            Console.ReadLine();

        }

        static void buyuk(int sayi1,int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(sayi2);
            }
        }
    }
}
