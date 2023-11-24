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
        }
    }
}