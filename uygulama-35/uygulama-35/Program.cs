using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("Atm ye hoşgeldiniz");
            Console.WriteLine("yapmak istediğiniz işlemi seçiniz");

            string secim = Console.ReadLine();

            if(secim=="1")
            {
                Console.WriteLine("şuan ki bakiyeniz  :"+bakiye);
            }
            else if(secim=="2")
            {
                Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("kalan tutar  :" + (bakiye - cekilecek_tutar));
                
            }else if (secim == "3")
            {
                Console.WriteLine("yatırmak istediginiz mikatrı ekleyiniz");
                int yatıralacak_tutar = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("şuan ki faturanız  :" + yatıralacak_tutar + bakiye);

            }
            else if(secim=="Q")
            {
                Console.WriteLine("ATM ÇIKIŞ YAPILIYOR");
                Console.WriteLine("ÇIKIŞ YAPILDI İYİ GÜNLLER");

            }
            Console.ReadLine();

        }
    }
}
