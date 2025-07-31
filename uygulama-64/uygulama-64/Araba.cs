using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_64
{
     public class Araba
    {
        public int kapisayisi;
        public string arabaModel;
        public string arabarengi;

        public Araba()
        {
            Console.WriteLine("araba sınıfının yapıcı metoodu çalıştı");
        }


        public void mototrCalistir()
        {
            Console.WriteLine( "motor çalışıyor...");
        }
        public void kapilarikilitle()
        {
            Console.WriteLine("kapılar kilitleniyor...");
        }


    }
}
