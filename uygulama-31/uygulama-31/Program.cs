using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 5;

            string a = sayi1.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(a + b);
            Console.ReadLine();

            double sayi = 5.22;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();
        }
    }
}
