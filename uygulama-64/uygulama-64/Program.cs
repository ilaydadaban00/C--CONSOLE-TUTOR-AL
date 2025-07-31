using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_64
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba araba = new Araba();
            araba.kapisayisi = 4;
            araba.arabaModel = "renault";
            araba.arabarengi = "kırmızı";

            araba.mototrCalistir();
            araba.kapilarikilitle();


            Console.WriteLine("arabanın kapı sayısı"+ araba.kapisayisi);
            Console.WriteLine("arabanın modeli"+araba.arabaModel);
            Console.WriteLine("arabanaın rengi"+araba.arabarengi);

        }
    }
}
