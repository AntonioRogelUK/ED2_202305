using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_Proyecto
{
    internal class Lista
    {
        class Grafo
        {
            private List<Nodo> nodos;

            public Grafo()
            {
                nodos = new List<Nodo>();
            }

            public void AgregarNodo(int dato)
            {
                Nodo nuevoNodo = new Nodo(dato);
                nodos.Add(nuevoNodo);
            }


        }
    }
}
