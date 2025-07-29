using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_37
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;

            Console.WriteLine("Atm hoşgeldiniz...");
            Console.WriteLine("lütfen seçim yapınız");
            Console.WriteLine("1- bakiye görüntüleme");
            Console.WriteLine("2- para çek");
            Console.WriteLine("3- para yatır");
            Console.WriteLine("4- çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    Console.WriteLine("bakiyeniz" + bakiye);
                    Console.ReadLine();

                    break;

                case "2":
                    Console.WriteLine("çekeceğiniz tutatrı girer misiniz");
                    int paraCek = Convert.ToInt32(Console.ReadLine());
                    if (paraCek > bakiye)
                    {
                        Console.WriteLine("çekeceğiniz tutar bakiyenizden fazla");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("bakiyeniz  " + (bakiye - paraCek));
                        Console.ReadLine();

                    }
                    Console.ReadLine();


                    break;


                case "3":
                    Console.WriteLine("çekeceğiniz tutatrı girer misiniz");
                    int parayatır = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("bakiyeniz  " + (bakiye + parayatır));
                    Console.ReadLine();


                    break;
                case "4":

                    Console.WriteLine("Atm çıkış yapılıyor");
                    Console.ReadLine();


                    break;


                default:

                    Console.WriteLine("lütfen geçerli değer giriniz");

                    break;



            }


        }
    }
}
