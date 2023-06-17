using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ArbolBinarioDeBusqueda
    {
        // El nodo hijo sera para la izquierda, el nodo hermano sera para la derecha, aprovechando asi la clase Nodo ya existente
        private readonly NodoArbolBinario raiz;
        public NodoArbolBinario Raiz { get { return raiz; } }

        public ArbolBinarioDeBusqueda(int dato)
        {
            raiz = new NodoArbolBinario(dato);
        }

        public void Insertar(int dato)
        {
            if (raiz == null)
            {
                throw new Exception("No se ha inicializado el arbol");
            }
            NodoArbolBinario actual = raiz;
            while (actual != null)
            {
                // El numero se repite
                if (actual.Dato == dato)
                    return;
                else if (dato < actual.Dato)
                {
                    if (actual.Menor != null)
                        actual = actual.Menor;
                    else
                    {
                        actual.Menor = new NodoArbolBinario(dato);
                        actual = actual.Menor;
                        break;
                    }

                }
                else if (dato > actual.Dato)
                {
                    if (actual.Mayor != null)
                        actual = actual.Mayor;
                    else
                    {
                        actual.Mayor = new NodoArbolBinario(dato);
                        actual = actual.Mayor;
                        break;
                    }
                }
            }
        }

        public string ObtenerArbol()
        {
            if (raiz == null)
                throw new Exception("El arbol esta vacio");
            NodoArbolBinario actual = raiz;
            int profundidad = 0;  
            string datos = "";
            Recorrer(actual, profundidad, ref datos);
            return datos;
        }

        // Recorrido en preorden (valor, sub izq, sub der)
        private void Recorrer(NodoArbolBinario actual, int profundidad, ref string datos)
        {
            if (actual != null)
            {
                datos += $"{new string('-',profundidad) + actual.Dato}\n";

                if (actual.Menor != null)
                {
                    Recorrer(actual.Menor, profundidad + 1, ref datos);
                }
                if (actual.Mayor != null)
                {
                    Recorrer(actual.Mayor, profundidad + 1, ref datos);
                }
            }
        }
    }
}
