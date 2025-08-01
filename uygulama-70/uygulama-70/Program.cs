using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_70
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();


            calisan.calisanID = 1;
            calisan.isim = "ilayda";
            calisan.soyisim = "daban";
            calisan.maas = 2500;


            Console.WriteLine("çalışan ID"+calisan.calisanID);
            Console.WriteLine("ilayda" + calisan.isim);
            Console.WriteLine("daban" + calisan.soyisim);
            Console.WriteLine(" maas" + calisan.maas);

            Console.ReadLine();



        }
    }
}
