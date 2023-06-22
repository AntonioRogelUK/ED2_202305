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

            Console.WriteLine("\nArbol General");
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
            ImprimirRenglones(arbolGeneral.ObtenerArbol());

            Console.WriteLine("\nArbol Binario de Busqueda");
            ABB abb = new ABB(200);
            abb.Insertar(100);
            abb.Insertar(50);
            abb.Insertar(25);
            abb.Insertar(75);
            abb.Insertar(300);
            abb.Insertar(250);

            ImprimirRenglones(abb.ObtenerArbol());
         
            Console.ReadLine();
        }

        static void ImprimirRenglones(string recorrido)
        {
            string[] renglones = recorrido.Split('\n');
            foreach (string renglon in renglones)
            {
                int cuentaGuiones = renglon.Count(c => c.ToString() == "-") + 2;
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cuentaGuiones.ToString());
                Console.WriteLine(renglon);
                Console.ResetColor();
            }
        }
    }
}
