using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ArbolBinario
    {
        private readonly NodoB raiz;
        public NodoB Raiz { get { return raiz; } }

        public ArbolBinario(int num)
        {
            raiz = new NodoB(num);
        }

        public void InsertarNodo(int num, NodoB aux)
        {
            if (num == aux.Num) return;

            if (num < aux.Num)
            {
                if (aux.Izq == null)
                {
                    aux.Izq = new NodoB(num);
                }else
                {
                    InsertarNodo(num, aux.Izq);
                }
            }

            if (num > aux.Num)
            {
                if (aux.Der == null)
                {
                    aux.Der = new NodoB(num);
                }
                else
                {
                    InsertarNodo(num, aux.Der);
                }
            }  
        }

        public string ObtenerArbol(NodoB nodoInicial = null)
        {
            if (nodoInicial == null)
            {
                nodoInicial = raiz;
            }

            int posicion = 0;
            string datos = string.Empty;

            Recorrer(nodoInicial, ref posicion, ref datos);
            return datos;
        }

        private void Recorrer(NodoB nodoInicial, ref int posicion, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Num.ToString();
                int cantidadGuiones = dato.Length + posicion;
                datos += $"{dato.PadLeft(cantidadGuiones, '-')}\n";

                if (nodoInicial.Izq != null)
                {
                    posicion++;
                    Recorrer(nodoInicial.Izq, ref posicion, ref datos);
                    posicion--;
                }

                if (nodoInicial.Der != null)
                {
                    posicion++;
                    Recorrer(nodoInicial.Der, ref posicion, ref datos);
                    posicion--;
                }
            }
        }
    }
}
