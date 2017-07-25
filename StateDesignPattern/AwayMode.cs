using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class AwayMode : IMode
    {
        public void Answer()
        {
            System.Console.WriteLine("Sizin için geri döndüm nasıl yardımcı?");
        }
    }
}
