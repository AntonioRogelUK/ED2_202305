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

            Console.WriteLine("---------------------------");
            Console.WriteLine("-------Arbol General-------");
            Console.WriteLine("---------------------------");

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

            Console.WriteLine("---------------------------");
            Console.WriteLine("-------Arbol Binario-------");
            Console.WriteLine("---------------------------");

            ArbolBinario arbolBinario = new ArbolBinario(20);

            arbolBinario.InsertarBi(10, arbolBinario.Raiz);
            arbolBinario.InsertarBi(5, arbolBinario.Raiz);
            arbolBinario.InsertarBi(50, arbolBinario.Raiz);
            arbolBinario.InsertarBi(30, arbolBinario.Raiz);
            arbolBinario.InsertarBi(70, arbolBinario.Raiz);
            arbolBinario.InsertarBi(12, arbolBinario.Raiz);
            arbolBinario.InsertarBi(64, arbolBinario.Raiz);
            arbolBinario.InsertarBi(93, arbolBinario.Raiz);
            arbolBinario.InsertarBi(23, arbolBinario.Raiz);

            string arbolBi = arbolBinario.ObtenerArbolBi();
            string[] renglonesB = arbolBi.Split('\n');
            foreach (string renglon in renglonesB)
            {
                int cuentaGuiones = renglon.Count(c => c.ToString() == "-") + 2;
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cuentaGuiones.ToString());
                Console.WriteLine(renglon);
                Console.ResetColor();
            }


            Console.ReadLine();
        }
    }
}
