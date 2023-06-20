using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinBusq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArbolBinBusq arbolBinario = new ArbolBinBusq(50);

            Nodo nodo1 = arbolBinario.InsertarNodo(45, arbolBinario.Raiz);
            Nodo nodo2 = arbolBinario.InsertarNodo(65, arbolBinario.Raiz);
            Nodo nodo3 = arbolBinario.InsertarNodo(30, nodo1);
            Nodo nodo4 = arbolBinario.InsertarNodo(25, nodo3);
            Nodo nodo5 = arbolBinario.InsertarNodo(100, nodo2);
            Nodo nodo6 = arbolBinario.InsertarNodo(0, nodo4);
            arbolBinario.ObtenerArbol();


            Console.ReadLine();

        }
    }
}
