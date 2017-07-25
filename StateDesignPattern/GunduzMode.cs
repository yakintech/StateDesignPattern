using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class GunduzMode : IMode
    {
        public void Answer()
        {
            System.Console.WriteLine("Şu an görüşmeye açık");
        }
    }
}
