using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinBusq
{
    internal class ArbolBinBusq
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }

        public ArbolBinBusq(int dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo InsertarNodo(int dato, Nodo nodoPadre)
        {
            if (dato == nodoPadre.Dato)
            {
                throw new Exception("Ingresa un dato diferente");
            }
            if (nodoPadre == null)
            {
                throw new Exception("No se ha especificado padre");
            }
            if (nodoPadre.Izquierda != null && nodoPadre.Derecha != null)
            {
                throw new Exception("El padre ya tiene un hijo asignado");
            }
            if (dato < nodoPadre.Dato)
            {
                nodoPadre.Izquierda = new Nodo(dato);
                return nodoPadre.Izquierda;
            }
            else
            {
                nodoPadre.Derecha = new Nodo(dato);
                return nodoPadre.Derecha;
            }
           
        }

        public int ObtenerArbol(Nodo nodoInicial = null)
        {
            nodoInicial = raiz;
            RecorrerPreorden(nodoInicial);
            return nodoInicial.Dato;
        }

        private void RecorrerPreorden(Nodo nodoInicial)
        {
            if (nodoInicial != null)
            {

                Console.WriteLine(nodoInicial.Dato + " ");
                RecorrerPreorden(nodoInicial.Izquierda);
                RecorrerPreorden(nodoInicial.Derecha);
             
            }

        }

        public Nodo Buscar(int dato, Nodo nodoBusqueda = null)
        {
            if (nodoBusqueda == null)
            {
                nodoBusqueda = raiz;
            }

            if (nodoBusqueda.Dato == dato)
            {
                return nodoBusqueda;
            }

            if (nodoBusqueda.Hermano != null)
            {
                Nodo nodoEncontrado = Buscar(dato, nodoBusqueda.Hermano);

                if (nodoEncontrado != null)
                {
                    return nodoEncontrado;
                }
            }
            return null;
        }

    }
}
