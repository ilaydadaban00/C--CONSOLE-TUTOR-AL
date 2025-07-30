using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_51
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[4];

            isimler[0] = "ilayda";

            isimler[1] = "melek";

            isimler[2] = "rukiye";

            isimler[3] = "dilan";

            for (int i=0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();
        }
    }
}
