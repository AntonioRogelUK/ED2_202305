﻿using System;
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
            

            ArbolBinarioDeBusqueda arbolBinario = new ArbolBinarioDeBusqueda(50);
            arbolBinario.Insertar(20);
            arbolBinario.Insertar(70);
            arbolBinario.Insertar(18);
            arbolBinario.Insertar(19);
            arbolBinario.Insertar(17);
            arbolBinario.Insertar(140);
            arbolBinario.Insertar(30);

            string arbolBin = arbolBinario.ObtenerArbol();
            foreach (string renglon in arbolBin.Split('\n'))
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
