using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı girer misin");
            int deger = Convert.ToInt32(Console.ReadLine());
            TekmiCiftmi(deger);
            Console.ReadLine();
        }
        static void TekmiCiftmi(int sayi)
        {
            if (sayi % 2 == 1)
            {
                Console.WriteLine("sayınız tektir...");
            }
            else
            {
                Console.WriteLine("sayınız çifftir");
            }
        }
    }
}
