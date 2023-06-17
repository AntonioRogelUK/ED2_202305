using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles {
    internal class ArbolBinario {
        private readonly NodoBinario raiz;
        public NodoBinario Raiz { get { return raiz; } }

        public ArbolBinario(int dato) {
            raiz = new NodoBinario(dato);
        }

        public Nodo InsertarNodo(int dato) {
            if (int == null) {
                throw new Exception("No se a especificado dato");
            }

            NodoBinario nodoActual = Raiz;
            NodoBinario nodoAnterior;

            while (nodoActual != null) {
                if (dato > nodoActual.Dato) {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.HijoDerecho;
                } else if (dato < nodoActual.Dato)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.HijoIzquierdo;
                } else if (dato = nodoActual.Dato)
                {
                    throw new Exception("El dato ingresado ya se encuentra en el árbol");
                }
            }

            if (dato > nodoAnterior.Dato)
            {
                nodoAnterior.HijoDerecho = new NodoBinario(dato);
                return nodoAnterior.HijoDerecho;
            }
            else if (dato < nodoActual.Dato)
            {
                nodoAnterior.HijoIzquierdo = new NodoBinario(dato);
                return nodoAnterior.HijoIzquierdo;
            }
        }

        public string ObtenerArbol(Nodo nodoInicial = null) {
            if (nodoInicial == null) {
                nodoInicial = raiz;
            }

            int posicion = 0;
            string datos = string.Empty;

            RecorrerArbol(nodoInicial, ref posicion, ref datos);
            return datos;
        }

        private void RecorrerArbol(NodoBinario nodoInicial, ref int posicion, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Dato.toString();
                int cantidadGuiones = dato.Length + posicion;
                datos += $"{dato.PadLeft(cantidadGuiones, '-')}\n";

                if (nodoInicial.Hijo != null)
                {
                    posicion++;
                    Recorrer(nodoInicial.Hijo, ref posicion, ref datos);
                    posicion--;
                }

                if (nodoInicial.Hermano != null && posicion != 0)
                {
                    Recorrer(nodoInicial.Hermano, ref posicion, ref datos);
                }
            }
        }

        public Nodo Buscar(string dato, Nodo nodoBusqueda = null) {
            if (nodoBusqueda == null) {
                nodoBusqueda = raiz;
            }

            if (nodoBusqueda.Dato.ToUpper() == dato.ToUpper()) {
                return nodoBusqueda;
            }

            if (nodoBusqueda.Hijo != null) {
                Nodo nodoEncontrado = Buscar(dato, nodoBusqueda.Hijo);

                if (nodoEncontrado != null) {
                    return nodoEncontrado;
                }
            }

            if (nodoBusqueda.Hermano != null) {
                Nodo nodoEncontrado = Buscar(dato, nodoBusqueda.Hermano);

                if (nodoEncontrado != null) {
                    return nodoEncontrado;
                }
            }
            return null;
        }
    }
}

