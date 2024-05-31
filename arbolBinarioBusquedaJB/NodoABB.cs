using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolBinarioBusquedaJB
{
    internal class NodoABB
    {
        public NodoABB? RamaIzquierda { get; set; }
        public int? Informacion { get; set; }
        public NodoABB? RamaDerecha { get; set; }

        public NodoABB()
        {
            RamaIzquierda = null;
            Informacion = 0;
            RamaDerecha = null;
        }

        public NodoABB(int? informacion)
        {
            RamaIzquierda = null;
            Informacion = informacion;
            RamaDerecha = null;
        }
    }
}
