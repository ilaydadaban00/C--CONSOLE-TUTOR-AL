using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 5;

            byte ikinci = 10;
            byte ucuncu = 244;
            byte maxdeger = byte.MaxValue;  //bu değer byte en alabileceği en büyük değeri gösterir.
            byte mindeger = byte.MinValue;  //bu değer byte en alabileceği en küçğk değeri gösterir.

            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            
            Console.ReadLine();
        }
    }
}
