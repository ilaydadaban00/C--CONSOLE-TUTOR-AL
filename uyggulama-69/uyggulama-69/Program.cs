using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyggulama_69
{
    class Program
    {
        static void Main(string[] args){

            Musteri musteri = new Musteri();

            musteri.kilo = 85;
            musteri.kilo2 = 85;
            Console.WriteLine("kilonuuzzz"+musteri.kilo);
            Console.WriteLine("kilonuz "+musteri.kilo2);

            Console.ReadLine();
          
        }
    }
}
