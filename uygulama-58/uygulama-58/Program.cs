using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_58
{
    class Program
    {
        static void Main(string[] args)
        {
         int donendeger=   toplamyap(6, 2);

            if (donendeger > 10)
            {
                Console.WriteLine("değer 10'dan buyuk");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("değer 10'dan küçük");
                Console.ReadLine();
            }
        }
        static int toplamyap(int deger1,int deger2)
        {
            int sonuc = deger1 + deger2;
            return sonuc; 
        }


    }
}
