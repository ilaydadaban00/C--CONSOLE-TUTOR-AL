using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("not1 girer misin");
            string not1 = Console.ReadLine();

            Console.WriteLine("not2 girer misin");
            string not2 = Console.ReadLine();

            Console.WriteLine("not3 girer misin");
            string not3 = Console.ReadLine();

            int n1 = Convert.ToInt32(not1);
            int n2 = Convert.ToInt32(not2);
            int n3 = Convert.ToInt32(not3);


            int ort =(n1 + n2 + n3)/3;

            double ortalama = Convert.ToDouble(ort);

            if (ortalama>= 80 && ortalama< 100)
            {
                Console.WriteLine("A+");
            }
            else if(ortalama >= 60 && ortalama < 80)
            {
                Console.WriteLine("A");
            }
            else if (ortalama >= 40 && ortalama < 60)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("F");
            }


            Console.ReadLine();

        }
    }
}
