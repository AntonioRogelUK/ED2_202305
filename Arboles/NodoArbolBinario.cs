using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class NodoArbolBinario
    {
        // La clase Nodo usa string, y necesitamos int
        public int Dato { get; set; }
        public NodoArbolBinario Menor { get; set; }
        public NodoArbolBinario Mayor { get; set; }

        public NodoArbolBinario(int dato)
        {
            Dato = dato;
            Menor = null;
            Mayor = null;
        }

    }
}
