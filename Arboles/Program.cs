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
         

            ArbolBinario arbolBinario = new ArbolBinario(50);

            arbolBinario.InsertarNodoB(30, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(70, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(40, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(60, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(35, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(80, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(75, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(45, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(55, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(65, arbolBinario.Raiz);
            arbolBinario.InsertarNodoB(85, arbolBinario.Raiz);

            string arbolB = arbolBinario.ObtenerArbol();
            string[] renglonesB = arbolB.Split('\n');
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
