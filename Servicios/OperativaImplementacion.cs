using actividadPropia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadPropia.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void crearCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = nuevoCliente();

            listaAntigua.Add(cliente);
        }

        private ClienteDto nuevoCliente()
        {
            ClienteDto cliente= new ClienteDto();

            Console.WriteLine("Introduzca el id del cliente: ");
            cliente.Id=Int64.Parse(Console.ReadLine()); 
            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca el Dni del cliente: ");
            cliente.Dni = Console.ReadLine();
            Console.WriteLine("Introduzca el telefono del cliente: ");
            cliente.Telefono = Console.ReadLine();

            return cliente;
        }

        public void eliminarCliente(List<ClienteDto> listaAntigua)
        {
            string dniAbuscar;
            ClienteDto clienteABorrar= new ClienteDto();
            Console.WriteLine("Introduce el Dni a buscar para borrar el cliente:");
            dniAbuscar = Console.ReadLine();

            foreach(ClienteDto cliente in listaAntigua)
            {
                if (cliente.Dni.Equals(dniAbuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }
            listaAntigua.Remove(clienteABorrar);

            
        }
    }
}
