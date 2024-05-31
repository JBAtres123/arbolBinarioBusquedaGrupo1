namespace arbolBinarioBusquedaJB
{
     class Program
    {
        static void Main(string[] args)
        {
            ABB abb = new ABB();

            abb.PoblarABB(abb.NodoRaiz, new NodoABB(120));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(87));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(43));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(22));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(65));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(56));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(99));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(93));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(140));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(130));
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(135));

            // Recorrido inorden
            Console.WriteLine("Recorrido Inorden:");
            abb.RecorridoInorden(abb.NodoRaiz);
            Console.WriteLine();

            // Recorrido postorden
            Console.WriteLine("Recorrido Postorden:");
            abb.RecorridoPostorden(abb.NodoRaiz);
            Console.WriteLine();

            // Búsqueda
            Console.WriteLine("\nBúsqueda:");
            int valorABuscar = 99;
            NodoABB nodoBuscado = abb.BuscarNodo(abb.NodoRaiz, valorABuscar);
            Console.WriteLine($"Nodo buscado con valor {valorABuscar}: {(nodoBuscado != null ? nodoBuscado.Informacion.ToString() : "No encontrado")}");

            // Inserción
            int valorAInsertar = 105;
            Console.WriteLine($"\nInserción de nodo con valor {valorAInsertar}:");
            abb.PoblarABB(abb.NodoRaiz, new NodoABB(valorAInsertar));
            Console.WriteLine("Recorrido Inorden después de la inserción:");
            abb.RecorridoInorden(abb.NodoRaiz);
            Console.WriteLine();

            // Eliminación
            int valorAEliminar = 87;
            Console.WriteLine($"\nEliminación del nodo con valor {valorAEliminar}:");
            abb.Eliminar(valorAEliminar);
            Console.WriteLine("Recorrido Inorden después de la eliminación:");
            abb.RecorridoInorden(abb.NodoRaiz);

            Console.ReadKey();
        }
    }
}
