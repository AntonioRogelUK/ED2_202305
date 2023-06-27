using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class ArbolBinarioBusqueda
    {
        private readonly Nodo raiz;
        public Nodo Raiz { get { return raiz; } }

        public ArbolBinarioBusqueda(int dato)
        {
            raiz = new Nodo(dato);
        }

        public void InsertarNodo(int dato) 
        {
            Nodo nodoActual = raiz;
            Nodo nodoAnterior = raiz;

            while (nodoActual != null) // Mientras que el nodo en el que estemos no sea null que se mueva por el arbol para encontrar el lugar donde insertarlo
            {
                if(dato == nodoActual.Dato) // Si el dato es igual algun dato que ya existe, entonces que se salga
                {
                    return;
                }
                else if (dato > nodoActual.Dato)    // Si el dato es mayor al nodoActual entonces guardamos el nodoActual en nodo Anterior para saber 
                {                                   // donde hacer cambios y se mueva al hijo derecho.
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Hderecho;
                }
                else if(dato < nodoActual.Dato) // Si el dato es menor al nodoActual entonces guardamos el nodoActual en nodo Anterior para saber 
                {                                   // donde hacer cambios y  se mueva al hijo izquierdo.
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Hizquierdo;
                }
            }

            // Se inserta en el hijo correspondiente
            if (dato > nodoAnterior.Dato)
            {
                nodoAnterior.Hderecho = new Nodo(dato);
            }
            if (dato < nodoAnterior.Dato)
            {
                nodoAnterior.Hizquierdo = new Nodo(dato);
            }
        }

        // Obtenemos todos los recorridos usando recursividad
        public string ObtenerArbol(Nodo nodoInicial = null)
        {
            if (nodoInicial == null)
            {
                nodoInicial = raiz;
            }

            string datos = string.Empty;

            datos += $"Preorden:\n";
            RecorrerPre(nodoInicial, ref datos);
            datos += $"\nInorden:\n";
            RecorrerIno(nodoInicial, ref datos);
            datos += $"\nPosorden:\n";
            RecorrerPos(nodoInicial, ref datos);
            return datos;
        }

        private void RecorrerPre(Nodo nodoInicial, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Dato.ToString();
                datos += $"{dato}, ";

                if (nodoInicial.Hizquierdo != null)
                {
                    RecorrerPre(nodoInicial.Hizquierdo, ref datos);                  
                }
                if (nodoInicial.Hderecho != null)
                {
                    RecorrerPre(nodoInicial.Hderecho, ref datos); 
                }
            }
        }
        private void RecorrerIno(Nodo nodoInicial, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Dato.ToString();

                if (nodoInicial.Hizquierdo != null)
                {
                    RecorrerIno(nodoInicial.Hizquierdo, ref datos);
                }
                datos += $"{dato}, ";
                if (nodoInicial.Hderecho != null)
                {
                    RecorrerIno(nodoInicial.Hderecho, ref datos);
                }
            }
        }
        private void RecorrerPos(Nodo nodoInicial, ref string datos)
        {
            if (nodoInicial != null)
            {
                string dato = nodoInicial.Dato.ToString();

                if (nodoInicial.Hizquierdo != null)
                {
                    RecorrerPos(nodoInicial.Hizquierdo, ref datos);
                }
                if (nodoInicial.Hderecho != null)
                {
                    RecorrerPos(nodoInicial.Hderecho, ref datos);
                }
                datos += $"{dato}, ";
            }
        }
    }
}
