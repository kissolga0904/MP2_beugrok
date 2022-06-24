using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga
{
    class elso
    {
        public elso(int egesz)
        {
            if (egesz<0)
            {
                throw new EgyediException(); 
            }
        }

    }
}
