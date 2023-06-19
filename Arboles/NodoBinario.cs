using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class NodoBinario
    {
        public int Numero { get; set; }
        public NodoBinario Izq { get; set; }
        public NodoBinario Der { get; set; }

        public NodoBinario(int numero, NodoBinario izq = null, NodoBinario der = null)
        {
            Numero = numero;
            Izq = izq;
            Der = der;
        }
    }
}
