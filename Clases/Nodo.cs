using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUnidad3_Cesar.Clases
{
    class Nodo
    {
        private string dato;
        private int dato1;
        private Nodo siguiente;


        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        
        public int DatoInt
        {
            get { return dato1; }
            set { dato1 = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }

    
}
