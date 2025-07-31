


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.setIsim("ilayda");

            string isim = ogrenci.getIsim();
            if (isim == "ilayda")
            {
                Console.WriteLine("ilooooooo");
            }
            else
            {
                Console.WriteLine("başarısız");
            }
            Console.ReadLine();

        }

    }
}
