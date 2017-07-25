using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Asistan asistan = new Asistan();

            asistan.Answer();

            asistan.ChangeMode(new GeceMode());

            asistan.Answer();

            Console.ReadKey();
           
        }
    }
}
