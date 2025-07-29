using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen yaşınızı giriniz");
            string kullanıcı_yas = Console.ReadLine();
            int kullanıcı_yasInt = Convert.ToInt32(kullanıcı_yas);
            int kullanıcı_yasInt2 = int.Parse(kullanıcı_yas);

            Console.WriteLine(kullanıcı_yasInt);
            Console.WriteLine(kullanıcı_yasInt2);

            Console.ReadLine();

              
             
        }
    }
}
