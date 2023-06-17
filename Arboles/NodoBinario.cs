using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles {
    internal class NodoBinario
    {
        public int Dato { get; set; }
        public NodoBinario HijoIzquierdo { get; set; }
        public NodoBinario HijoDerecho { get; set; }

        public NodoBinario(int dato, NodoBinario izquierdo = null, NodoBinario derecho = null) {
            Dato = dato;
            HijoIzquierdo = izquierdo;
            HijoDerecho = derecho;
        }
    }
}
