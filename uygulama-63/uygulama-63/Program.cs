using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_63
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();

            araba1.kapiSayisi = 4;
            araba1.arabaRengi = "kırmızı";
            araba1.arabaModel = "Renault";


            araba1.kapikilitlimi();
            araba1.motorCalistir();
            Console.WriteLine("arabanın kapı sayısı" + araba1.kapiSayisi);
            Console.WriteLine("arabanın rengi " + araba1.arabaRengi);
            Console.WriteLine("arabanın modeli " + araba1.arabaModel);
            Console.ReadLine();
            


        }
    }
}
