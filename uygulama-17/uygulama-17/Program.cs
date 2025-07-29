using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 4;
            int sayi2 = 2;
            int sayi3 = 2;

            bool kontrol2 = sayi3 == sayi2;

            bool kontrol1 = sayi1 == sayi2;
            Console.WriteLine(kontrol1);
            Console.WriteLine(kontrol2);

            Console.ReadLine();
        }
    }
}
