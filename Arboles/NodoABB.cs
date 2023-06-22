using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class NodoABB
    {
        // Izq es para los menores y Der para los mayores
        public int Dato { get; set; }
        public NodoABB Izq { get; set; }
        public NodoABB Der { get; set; }

        public NodoABB(int dato)
        {
            Dato = dato;
            Izq = null;
            Der = null;
        }
    }
}
