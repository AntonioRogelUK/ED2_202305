using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ArbolBinario
    {
        private readonly NodoBinario raiz;
        public NodoBinario Raiz { get { return raiz; } }

        public ArbolBinario(int numero)
        {
            raiz = new NodoBinario(numero);
        }

        public void InsertarNodoB(int numero, NodoBinario aux)
        {
            if (numero == aux.Numero) return;

            if (numero < aux.Numero)
            {
                if (aux.Izq == null)
                {
                    aux.Izq = new NodoBinario(numero);
                }else
                {
                    InsertarNodoB(numero, aux.Izq);
                }
            }

            if (numero > aux.Numero)
            {
                if (aux.Der == null)
                {
                    aux.Der = new NodoBinario(numero);
                }
                else
                {
                    InsertarNodoB(numero, aux.Der);
                }
            }  
        }

        public string ObtenerArbol(NodoBinario nodoInicial = null)
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

        private void Recorrer(NodoBinario nodoInicial, ref int posicion, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Numero.ToString();
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
