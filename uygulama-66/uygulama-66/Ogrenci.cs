using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_66
{
    public class Ogrenci
    {
        private int no;

        private string isim;

        private string soyisim;

        private int vize1;

        private int vize2;

        private int final;

        private string okulismi;


        public Ogrenci(int _no, string _isim, string _soyisim, int _vize1, int _vize2,int _final, string _okulismi)
        {
            no = _no;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;

        }
        public void OgrenciBigileriGoster()
        {
            Console.WriteLine("öğrenci numarası" + no);
            Console.WriteLine("öğrenci isim" + isim);
            Console.WriteLine("öğrenci soyisim" + soyisim);
            Console.WriteLine("öğrenci vize1" + vize1);
            Console.WriteLine("öğrenci vize2" + vize2);
            Console.WriteLine("öğrenci final" + final);
            Console.WriteLine("öğrenci okulismi" + okulismi);



        }

        public double ogrenciNotuBul()
        {
            double ortalama=  vize1 * 0.20 + vize2 * 0.20 + final * 0.60;
            return ortalama;
        }

        public void okulgetir()
        {
            Console.WriteLine("okulun adı"+okulismi);
        }
    }
}

    
