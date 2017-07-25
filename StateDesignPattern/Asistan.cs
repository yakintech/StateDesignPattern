using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Asistan
    {
        IMode amode;

        public Asistan()
        {
            this.amode = new GunduzMode();
        }

        public void ChangeMode(IMode mode)
        {
            this.amode = mode;
        }

        public void Answer()
        {
            this.amode.Answer();
        }
    }
}
