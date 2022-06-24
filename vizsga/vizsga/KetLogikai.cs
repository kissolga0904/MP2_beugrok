using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga
{
    class KetLogikai: ICloneable
    {
        bool valami = true;
        bool valami2 = false;

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
