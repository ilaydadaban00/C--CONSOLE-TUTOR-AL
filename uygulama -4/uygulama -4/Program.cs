using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama__4
{
    class Program
    {
        static void Main(string[] args)
        {
            // short değişkeni -32768 ile 32768 arasındaki değerleri alabilir.

            short birinciDegisken = -50;

            short ikinciDegisten = 25550;
            short ucuncuDegisten = 32000;

            short maxDeger = short.MaxValue;
            short MinDeger = short.MaxValue;


            Console.WriteLine(maxDeger);
            Console.WriteLine(MinDeger);
            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisten);
            Console.WriteLine(ucuncuDegisten);


            Console.ReadLine();

        }
    }
}
