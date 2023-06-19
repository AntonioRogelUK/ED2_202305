using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class NodoBinario
    {
        public int Dato { get; set; }
        public NodoBinario Izquierda {get; set; }
        public NodoBinario Derecha { get; set; }

        public NodoBinario (int dato,NodoBinario izquierda = null, NodoBinario derecha = null)
        {
            Dato = dato;
            Izquierda = izquierda;
            Derecha = derecha;
        }
    }
}
