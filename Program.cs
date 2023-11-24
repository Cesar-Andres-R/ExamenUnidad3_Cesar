using System;
using System.Runtime.Serialization.Formatters;
using ExamenUnidad3_Cesar.Clases;

namespace ExamenUnidad3_Cesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            for (int i = 0; i < 3; i++)
            {
                lista.InsertarNombre();
            }


            for (int i = 0; i < 3; i++)
            {
                lista.InsertarEdades();
            }

            
            
            Console.WriteLine("Los elementos son: ");
            lista.MostraLista();




            Console.WriteLine("Ingrese el nombre a buscar: ");
            string elementoABuscar = string.Format(Console.ReadLine());

            Nodo nodoEncontrado = lista.BuscarElemento(elementoABuscar);

            if (nodoEncontrado != null)
            {
                Console.WriteLine($"Elemento {elementoABuscar} encontrado en la lista.");
            }
            else
            {
                Console.WriteLine($"Elemento {elementoABuscar} no encontrado en la lista.");
            }
        }
    }
}