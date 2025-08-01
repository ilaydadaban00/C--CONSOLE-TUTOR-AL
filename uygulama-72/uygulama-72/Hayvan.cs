using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_72
{
    public class Hayvan
    {

        public string hayvan_ismi;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        private int hayvan_yas;



        public void hayvanBilgisiGoster()
        {
            Console.WriteLine("hayvanın ismi"+hayvan_ismi);
            Console.WriteLine("hayvanın rengi"+hayvan_rengi);
            Console.WriteLine("hayvanın cinsiyeti"+hayvan_cinsiyet);
        }
        
    }
}
