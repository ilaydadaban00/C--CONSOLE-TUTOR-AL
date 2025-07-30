using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen değer giriniz.");
            int deger = Convert.ToInt32(Console.ReadLine());
            int kare = kareal(deger);
            if (kare >= 25)
            {
                Console.WriteLine("değeriniz 25 eşit veya büyük");
            }
            else
            {
                Console.WriteLine("değeriniz küçüktür 25'den");
            }
            Console.ReadLine();

        }
        static int kareal(int a)
        {
            return a * a;
        }
        

    }
}
