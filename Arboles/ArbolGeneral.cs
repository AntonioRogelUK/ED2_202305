using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ArbolGeneral
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }

        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo InsertarNodo(string dato, Nodo nodoPadre)
        {
            if (nodoPadre == null)
            {
                throw new Exception("No se a especificado padre");
            }

            if(nodoPadre.Hijo == null)
            {
                nodoPadre.Hijo = new Nodo(dato);
                return nodoPadre.Hijo;
            }
            else
            {
                Nodo nodoActual = nodoPadre.Hijo;
                while(nodoActual.Hermano != null)
                {
                    nodoActual = nodoActual.Hermano;
                }
                nodoActual.Hermano = new Nodo(dato);
                return nodoActual.Hermano;
            }
        }
    }
}
