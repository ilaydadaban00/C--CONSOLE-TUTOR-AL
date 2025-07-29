using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_48
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            while(true)
                {
                Console.WriteLine("kullanıcı adınızı giriniz");
                string kullaniniciAdi = Console.ReadLine();
                Console.WriteLine(" sifrenizi giriniz");
                string sifre = Console.ReadLine();

                if(kullaniniciAdi=="ilayda" && sifre == "123")
                {
                    Console.WriteLine("tebrikler giriş yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("kullanıcı adınız veya şifreniiz hatalı");
                    if (hak > 0)
                    {
                        hak -= 1;
                    }
                    else
                    {
                        break;
                    }
                }
                

            }
        }
    }
}
