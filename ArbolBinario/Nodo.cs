using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Nodo
    {
        public int Dato { get; set; }
        public Nodo Hderecho { get; set; }
        public Nodo Hizquierdo { get; set; }

        public Nodo(int dato, Nodo hderecho = null, Nodo hizquierdo = null)
        {
            Dato = dato;
            Hderecho = hderecho;
            Hizquierdo = hizquierdo;
        }
    }
}
