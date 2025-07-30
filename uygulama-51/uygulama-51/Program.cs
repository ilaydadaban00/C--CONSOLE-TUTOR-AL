using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_51
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] sayilar = new double[4];

            sayilar[0] = 3.74;

            sayilar[1] = 5.4;

            sayilar[2] = 8.4;

            sayilar[3] = 4.9;

            for (int i=0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
