using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolBinarioBusquedaJB
{
    internal class ABB
    {
        public NodoABB? NodoRaiz { get; set; }

        public ABB()
        {
            NodoRaiz = null;
        }

        public void PoblarABB(NodoABB nodoPadre, NodoABB nuevoNodo)
        {
            if (nodoPadre == null)
            {
                NodoRaiz = nuevoNodo;
                return;
            }

            if (nodoPadre.Informacion > nuevoNodo.Informacion)
            {
                // seleccionar rama izquierda
                if (nodoPadre.RamaIzquierda == null)
                {
                    nodoPadre.RamaIzquierda = nuevoNodo;
                    return;
                }
                else
                {
                    PoblarABB(nodoPadre.RamaIzquierda, nuevoNodo);
                }
            }

            if (nodoPadre.Informacion < nuevoNodo.Informacion)
            {
                // seleccionar rama derecha
                if (nodoPadre.RamaDerecha == null)
                {
                    nodoPadre.RamaDerecha = nuevoNodo;
                    return;
                }
                else
                {
                    PoblarABB(nodoPadre.RamaDerecha, nuevoNodo);
                }
            }
        }

        public NodoABB BuscarNodo(NodoABB nodoPadre, int llave)
        {
            if (nodoPadre == null)
            {
                return null;
            }
            else
            {
                if (nodoPadre.Informacion == llave)
                {
                    return nodoPadre;
                }
                else
                {
                    if (nodoPadre.Informacion > llave)
                    {
                        return BuscarNodo(nodoPadre.RamaIzquierda, llave);
                    }
                    else
                    {
                        return BuscarNodo(nodoPadre.RamaDerecha, llave);
                    }
                }
            }
        }

        public void Eliminar(int llave)
        {
            NodoRaiz = EliminarNodo(NodoRaiz, llave);
        }

        private NodoABB? EliminarNodo(NodoABB? nodo, int llave)
        {
            if (nodo == null) return null;

            if (llave < nodo.Informacion)
            {
                nodo.RamaIzquierda = EliminarNodo(nodo.RamaIzquierda, llave);
            }
            else if (llave > nodo.Informacion)
            {
                nodo.RamaDerecha = EliminarNodo(nodo.RamaDerecha, llave);
            }
            else
            {
                // Caso 1: Nodo terminal (hoja)
                if (nodo.RamaIzquierda == null && nodo.RamaDerecha == null)
                {
                    return null;
                }
                // Caso 2: Nodo con un solo descendiente
                else if (nodo.RamaIzquierda == null)
                {
                    return nodo.RamaDerecha;
                }
                else if (nodo.RamaDerecha == null)
                {
                    return nodo.RamaIzquierda;
                }
                // Caso 3: Nodo con dos descendientes
                else
                {
                    NodoABB? sucesor = EncontrarSucesor(nodo.RamaDerecha);
                    if (sucesor != null)
                    {
                        nodo.Informacion = sucesor.Informacion;
                        nodo.RamaDerecha = EliminarNodo(nodo.RamaDerecha, sucesor.Informacion.Value);
                    }
                }
            }
            return nodo;
        }

        private NodoABB? EncontrarSucesor(NodoABB? nodo)
        {
            while (nodo?.RamaIzquierda != null)
            {
                nodo = nodo.RamaIzquierda;
            }
            return nodo;
        }

        public void RecorridoInorden(NodoABB nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoInorden(nodo.RamaIzquierda); // Visitar la rama izquierda primero
                Console.Write($" {nodo.Informacion} "); // Visitar el nodo actual
                RecorridoInorden(nodo.RamaDerecha); // Visitar la rama derecha al final
            }
        }

        public void RecorridoPostorden(NodoABB nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoPostorden(nodo.RamaIzquierda); // Visitar la rama izquierda primero
                RecorridoPostorden(nodo.RamaDerecha); // Visitar la rama derecha después
                Console.Write($" {nodo.Informacion} "); // Visitar el nodo actual al final
            }
        }
    }
}
