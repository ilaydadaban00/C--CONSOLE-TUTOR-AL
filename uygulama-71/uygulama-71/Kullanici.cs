using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_71
{
    class Kullanici
    {
        private int kullaniciID { get; set; }

        private string isim { get; set; }

        private string soyisim { get; set; }

        private static int maas { get; set; }




        static Kullanici()
        {
            maas = 2500;
        }

        public Kullanici(int kullaniciid, string _isim,string _soyisim)
        {
            kullaniciID = kullaniciid;
            isim = _isim;
            soyisim = _soyisim;
            

        }

        public void bilgigoster()
        {
            Console.WriteLine("kullanıcı adı"+kullaniciID);
            Console.WriteLine("isim"+isim);
            Console.WriteLine("soyiisim"+soyisim);
            Console.WriteLine("maas"+maas);
        }
        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("kullanıcıya zam yapılıyor");
            Console.WriteLine("şuanki maaş"+(maas+zamMiktari));
        }
    }

}
