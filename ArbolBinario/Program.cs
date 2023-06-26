using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ejemplo 1

            ArbolBinarioBusqueda arbolBB = new ArbolBinarioBusqueda(45);

            arbolBB.InsertarNodo(23);
            arbolBB.InsertarNodo(65);
            arbolBB.InsertarNodo(2);
            arbolBB.InsertarNodo(38);
            arbolBB.InsertarNodo(52);
            arbolBB.InsertarNodo(96);
            arbolBB.InsertarNodo(7);
            arbolBB.InsertarNodo(48);


            // Ejemplo 2

            //ArbolBinarioBusqueda arbolBB = new ArbolBinarioBusqueda(22);

            //arbolBB.InsertarNodo(15);
            //arbolBB.InsertarNodo(3);
            //arbolBB.InsertarNodo(8);
            //arbolBB.InsertarNodo(40);
            //arbolBB.InsertarNodo(45);
            //arbolBB.InsertarNodo(13);
            //arbolBB.InsertarNodo(20);
            //arbolBB.InsertarNodo(30);
            //arbolBB.InsertarNodo(1);
            //arbolBB.InsertarNodo(7);
            //arbolBB.InsertarNodo(34);
            //arbolBB.InsertarNodo(48);
            //arbolBB.InsertarNodo(53);
            //arbolBB.InsertarNodo(9);
            //arbolBB.InsertarNodo(23);
            //arbolBB.InsertarNodo(12);
            //arbolBB.InsertarNodo(51);
            //arbolBB.InsertarNodo(4);
            //arbolBB.InsertarNodo(10);

            string arbol = arbolBB.ObtenerArbol();
            Console.WriteLine(arbol);

            Console.ReadKey();
        }
    }
}
