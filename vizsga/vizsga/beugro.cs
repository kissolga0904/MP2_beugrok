using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga
{
    class beugro
    {
        int szam;
        int szam2;

        public beugro(int szam, int szam2)
        {
            this.szam = szam;
            this.szam2 = szam2;
        }
        public beugro() :this(0,10)
        {

        }
    }
}
