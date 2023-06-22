using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class ABB
    {
        private NodoABB Raiz { get; }

        public ABB(int dato)
        {
            Raiz = new NodoABB(dato);
        }

        public void Insertar(int dato)
        {
            if (Raiz == null)
            {
                throw new Exception("El arbol no tiene raiz");
            }

            NodoABB nodoABB = Raiz;
            while (nodoABB != null)
            {
                if (nodoABB.Dato == dato)
                {
                    throw new Exception("El valor ya existe en el arbol");
                }
                if (nodoABB.Dato > dato)
                {
                    if (nodoABB.Der != null)
                        nodoABB = nodoABB.Der;
                    else
                    {
                        nodoABB.Der = new NodoABB(dato);
                        break;
                    }
                }
                else
                {
                    if (nodoABB.Izq != null)
                        nodoABB = nodoABB.Izq;
                    else
                    {
                        nodoABB.Izq = new NodoABB(dato);
                        break;
                    }
                }
            }
        }

        public string ObtenerArbol()
        {
            if (Raiz == null)
            {
                throw new Exception("El arbol no tiene raiz");
            }
            string datos = string.Empty;
            Recorrer(Raiz, 0, ref datos);
            return datos;
        }


        private void Recorrer(NodoABB nodoABB, int profundidad, ref string datos)
        {
            if(nodoABB != null)
            {
                datos += $"{new string('-',profundidad)}{nodoABB.Dato}\n";
                if(nodoABB.Izq != null)
                    Recorrer(nodoABB.Izq, profundidad + 1, ref datos);
                if(nodoABB.Der != null)
                    Recorrer(nodoABB.Der, profundidad + 1,ref datos);
            }
        }
    }
}
