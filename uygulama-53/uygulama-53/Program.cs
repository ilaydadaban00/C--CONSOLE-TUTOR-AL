using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_53
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ilayda", "rukiye", "melek", "dilan", "beyza" };
            foreach (var a in isimler)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
