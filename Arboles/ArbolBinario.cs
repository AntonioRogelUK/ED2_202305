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

        public NodoBinario InsertarNodo(int dato)
        {
            if (dato == 0)
            {
                throw new Exception("No se a especificado dato");
            }

            NodoBinario nodoActual = Raiz;
            NodoBinario nodoAnterior = Raiz;

            while (nodoActual != null)
            {
                if (dato > nodoActual.Dato)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.HijoDerecho;
                }
                else if (dato < nodoActual.Dato)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.HijoIzquierdo;
                }
            }

            if (dato > nodoAnterior.Dato)
            {
                nodoAnterior.HijoDerecho = new NodoBinario(dato);
                return nodoAnterior.HijoDerecho;
            }
            else if (dato < nodoAnterior.Dato)
            {
                nodoAnterior.HijoIzquierdo = new NodoBinario(dato);
                return nodoAnterior.HijoIzquierdo;
            }

            return nodoActual;
        }

        public string ObtenerArbol(NodoBinario nodoInicial = null) {
            if (nodoInicial == null) {
                nodoInicial = Raiz;
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
                string dato = nodoInicial.Dato.ToString();
                int cantidadGuiones = dato.Length + posicion;
                datos += $"{dato.PadLeft(cantidadGuiones, '-')}\n";

                if (nodoInicial.HijoIzquierdo != null)
                {
                    posicion++;
                    RecorrerArbol(nodoInicial.HijoIzquierdo, ref posicion, ref datos);
                    posicion--;
                }

                if (nodoInicial.HijoDerecho != null)
                {
                    posicion++;
                    RecorrerArbol(nodoInicial.HijoDerecho, ref posicion, ref datos);
                    posicion--;
                }
            }
        }
    }
}

