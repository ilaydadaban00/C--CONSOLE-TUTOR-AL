using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = new int[4];


            for(int i = 1; i < sayi.Length; i++)
            {
                Console.Write("sayılar dizisinin"+(i)+"index değerini giriniz");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("***********************");

            for(int i = 0;i< sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
         
            }
            Console.ReadLine();
        }

    }
}
