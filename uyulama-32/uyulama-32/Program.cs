using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyulama_32
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lütfen birinci sayıyı giriniz");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            string sayi2 = Console.ReadLine();

            int a = Convert.ToInt32(sayi1);

            int b = Convert.ToInt32(sayi2);

            Console.WriteLine("verdiğiniz iki sayının toplamı  " + a + b);
            Console.ReadLine();
        }
    }
}
