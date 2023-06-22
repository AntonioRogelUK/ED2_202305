using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
       {
            ArbolBinario arbolBinario = new ArbolBinario(15);

            arbolBinario.InsertarNodo(20);
            arbolBinario.InsertarNodo(7);
            arbolBinario.InsertarNodo(8);
            arbolBinario.InsertarNodo(12);
            arbolBinario.InsertarNodo(54);
            arbolBinario.InsertarNodo(27);
            arbolBinario.InsertarNodo(5);
            arbolBinario.InsertarNodo(14);
            arbolBinario.InsertarNodo(10);
            arbolBinario.InsertarNodo(3);
            arbolBinario.InsertarNodo(31);

            
            string arbol = arbolBinario.ObtenerArbol();


            string[] renglones = arbol.Split('\n');
            foreach (string renglon in renglones)
            {
                int cuentaGuiones = renglon.Count(c => c.ToString() == "-") + 2;
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cuentaGuiones.ToString());
                Console.WriteLine(renglon);
                Console.ResetColor();
            }

            /* 
             * El comentario es solamente para obtener el puro resultado de arbol binario sin que interfiera el arbol general.
             * 
            ArbolGeneral arbolGeneral = new ArbolGeneral("A");

            Nodo nodoB = arbolGeneral.InsertarNodo("B",arbolGeneral.Raiz);
            Nodo nodoD = arbolGeneral.InsertarNodo("D", nodoB);
            Nodo nodoI = arbolGeneral.InsertarNodo("I", nodoD);
            Nodo nodoE = arbolGeneral.InsertarNodo("E", nodoB);
            Nodo nodoF = arbolGeneral.InsertarNodo("F", nodoB);
            Nodo nodoJ = arbolGeneral.InsertarNodo("J", nodoF);
            Nodo nodoK = arbolGeneral.InsertarNodo("K", nodoF);
            Nodo nodoC = arbolGeneral.InsertarNodo("C", arbolGeneral.Raiz);
            Nodo nodoG = arbolGeneral.InsertarNodo("G", nodoC);
            Nodo nodoH = arbolGeneral.InsertarNodo("H", nodoC);
            Nodo nodoL = arbolGeneral.InsertarNodo("L", nodoH);


            string arbol = arbolGeneral.ObtenerArbol();
            string[] renglones = arbol.Split('\n');
            foreach (string renglon in renglones)
            {
                int cuentaGuiones = renglon.Count(c => c.ToString()=="-")+2;
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),cuentaGuiones.ToString());
                Console.WriteLine(renglon);
                Console.ResetColor();
            }
            */


            Console.ReadLine();
            
        }
    }
}
