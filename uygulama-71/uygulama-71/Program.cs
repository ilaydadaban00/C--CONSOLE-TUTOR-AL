using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_71
{
    class Program
    {
        static void Main(string[] args)
        {

            Kullanici kullanici = new Kullanici(1,"ilayda","daban");

            kullanici.bilgigoster();
            kullanici.zamYap(700);
            Console.ReadLine();
        }
    }
}
