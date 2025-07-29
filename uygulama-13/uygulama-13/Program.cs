using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;            
            int sayi2 = 15;
            int sayi3 = 7;


            int sonuc1 = sayi1 + sayi2;
            int sonuc2 = (sayi1 + sayi2) - sayi3;

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);

            Console.ReadLine();
        }
    }
}
