using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_66
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci = new Ogrenci(1, "ilayda", "daban", 50, 40, 73, "hnk");

            while (true)
            {
                Console.WriteLine("                     ");
                Console.WriteLine("uygulamamıza hoşgeldiniz... yapmak istediğiniz işlemi yapınız");
                islemlerigoster();

                string secim = Console.ReadLine();


                switch (secim)
                {
                    case "1":

                        ogrenci.OgrenciBigileriGoster();
                        break;

                    case "2":

                        double ogrenciort = ogrenci.ogrenciNotuBul();
                        Console.WriteLine("ogrencşnin ortalaması"+ogrenciort);
                        break;

                    case "3":

                        ogrenci.okulgetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;

                }

            }


        }
        static void islemlerigoster()
        {

            Console.WriteLine("lütfen seçim yapınız");
            Console.WriteLine("1-Öğrenci bilgileri göster");
            Console.WriteLine("2-öğrenci ortalaması getir");
            Console.WriteLine("3-öğrenci okulunu öğren");
            Console.WriteLine("4- çıkış yap");
        }
        

       
    }
}
