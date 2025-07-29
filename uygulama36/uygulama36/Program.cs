using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lütfen boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double BedenKitleIndexi = kilo / (boy * boy);

            if (BedenKitleIndexi <= 18)
            {
                Console.WriteLine("zayıf");
                Console.ReadLine();

            }
            else if(BedenKitleIndexi>18 && BedenKitleIndexi < 25)
            {
                Console.WriteLine("normal");
                Console.ReadLine();


            }
            else if (BedenKitleIndexi > 25)
            {
                Console.WriteLine("obez");
                Console.ReadLine();

            }
        }
    }
}
