using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("notunu girer misin");
            string not = Console.ReadLine();
            int a = Convert.ToInt32(not);

            
            if (a>= 50)
            {
                Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("biraz daha çalışmalısın");
            }

            Console.ReadLine();
            
        }
    }
}
