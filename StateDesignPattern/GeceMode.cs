using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class GeceMode : IMode
    {
        public void Answer()
        {
            System.Console.WriteLine("Şu an görüşmeye kapalı");
        }
    }
}
