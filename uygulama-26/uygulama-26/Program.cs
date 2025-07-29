using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen adınızı giriniz.");

            string isim = Console.ReadLine();


            Console.WriteLine("soyad giriniz");
            string soyad = Console.ReadLine();


            Console.WriteLine("kullanıcının ismi :" + isim);
            Console.WriteLine("kullanıcının Soyad :" + soyad);

            Console.ReadLine();

        }
    }
}
