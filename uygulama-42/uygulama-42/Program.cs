using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0;
            while (a <= 100)
            {
                
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }
            Console.ReadLine();
        }
    }
}
