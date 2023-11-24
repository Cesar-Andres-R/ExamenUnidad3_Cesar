using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3_Cesar.Clases
{
    class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();


        public Lista() 
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNombre()
        {
            Nodo Nuevo = new Nodo();

            Console.WriteLine("Ingresa nombre de personas");
            
                Nuevo.Dato = string.Format(Console.ReadLine());


                if (Primero == null)
                {
                    Primero = Nuevo;
                    Primero.Siguiente = null;
                    Ultimo = Nuevo;
                }
                else
                {
                    Ultimo.Siguiente = Nuevo;
                    Nuevo.Siguiente = null;
                    Ultimo = Nuevo;
                }
                
            
        }


        public void InsertarEdades()
        {
            Nodo Nuevo = new Nodo();

            Console.WriteLine("Ingresa edades de la personas enteriores");
            
                Nuevo.DatoInt = int.Parse(Console.ReadLine());


                if (Primero == null)
                {
                    Primero = Nuevo;
                    Primero.Siguiente = null;
                    Ultimo = Nuevo;
                }
                else
                {
                    Ultimo.Siguiente = Nuevo;
                    Nuevo.Siguiente = null;
                    Ultimo = Nuevo;
                }
                
            
        }

        public void MostraLista()
        {
            Nodo Actual = new Nodo();

            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine($"Elemento es {Actual.Dato}");
                    Console.WriteLine($"Elemento es {Actual.DatoInt}");
                    Actual = Actual.Siguiente;
                }
                
            }
            
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }


        


    }
}
