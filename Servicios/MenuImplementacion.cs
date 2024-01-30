using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadPropia.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("################");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Dar alta cliente");
            Console.WriteLine("2. Eliminar cliente");
            Console.WriteLine("################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion=Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }

        
    }
}
