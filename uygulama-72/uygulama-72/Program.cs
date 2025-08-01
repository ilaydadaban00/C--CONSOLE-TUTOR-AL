using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvan_cinsiyet = "kız";
            kedi.hayvan_ismi = "pamuk";
            kedi.hayvan_rengi = "beyaz";

            kedi.hayvanBilgisiGoster();
            Console.ReadLine();

        }
    }
}
