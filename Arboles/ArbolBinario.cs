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

        public ArbolBinario(int dato)
        {
            raiz = new NodoBinario(dato);
        }

        public void InsertarBi(int dato, NodoBinario padreBi)
        {
            if (dato == padreBi.Dato)
            {
                throw new Exception("No se a especificado dato");
            }

            if (dato < padreBi.Dato)
            {
                if (padreBi.Izquierda == null)
                {
                    padreBi.Izquierda = new NodoBinario(dato);
                }
                else
                {
                    InsertarBi(dato, padreBi.Izquierda);
                }
            }

            if (dato > padreBi.Dato)
            {
                if (padreBi.Derecha == null)
                {
                    padreBi.Derecha = new NodoBinario(dato);
                }
                else
                {
                    InsertarBi(dato, padreBi.Derecha);
                }
            }
        }

        private void RecorrerBi(NodoBinario nodoInicial, ref int posicion, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Dato.ToString();
                int cantidadGuiones = dato.Length + posicion;
                datos += $"{dato.PadLeft(cantidadGuiones, '-')}\n";

                if (nodoInicial.Izquierda != null)
                {
                    posicion++;
                    RecorrerBi(nodoInicial.Izquierda, ref posicion, ref datos);
                    posicion--;
                }

                if (nodoInicial.Derecha != null)
                {
                    posicion++;
                    RecorrerBi(nodoInicial.Derecha, ref posicion, ref datos);
                    posicion--;
                }
            }
        }

        public string ObtenerArbolBi(NodoBinario nodoInicial = null)
        {
            if (nodoInicial == null)
            {
                nodoInicial = raiz;
            }

            int posicion = 0;
            string datos = string.Empty;

            RecorrerBi(nodoInicial, ref posicion, ref datos);
            return datos;
        }
    }
}
