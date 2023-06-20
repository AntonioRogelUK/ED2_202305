using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinBusq
{
    internal class Nodo
    {
        public int Dato { get; set; }
        public Nodo Hermano { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(int dato, Nodo hermano = null, Nodo izquierda = null, Nodo derecha = null)
        {
            Dato = dato;
            Hermano = hermano;
            Izquierda = izquierda;
            Derecha = derecha;  
        }
    }
}
