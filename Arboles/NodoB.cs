using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class NodoB
    {
        public int Num { get; set; }
        public NodoB Izq { get; set; }
        public NodoB Der { get; set; }

        public NodoB(int num, NodoB izq = null, NodoB der = null)
        {
            Num = num;
            Izq = izq;
            Der = der;
        }
    }
}
