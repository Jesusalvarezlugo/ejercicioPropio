using actividadPropia.Servicios;
using actividadPropia.Dtos;

namespace actividadPropia.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Crea una aplicación que se centre en la eliminacion de un cliente(se eliminara pidiendo el DNI).
             Para ello tendras que dar de alta a algun cliente y añadirlo a una lista.
             Tras añadirlo tendras que mostrarlo por pantalla(solo en nombre y dni), una vez hecho esto, tendras que 
             eliminar al cliente y volver a mostrar la lista.
             Para la entidad cliente ha de tener 4 campos:ID,nombre,apellidos,dni y telefono.
             Requisitos minimos:-Haz un menu
             -El proyecto ha de tener dos servicios, uno para el menu y otro para la operativa, ambos deben tener el mismo sufijo.
             -El menu ha de repetirse hasta que el usuario indique de cerrarlo.
             -La informacion se guardara en una lista.
             -Eliminar cliente y añadir cliente debe estar en metodos apartes en la carpeta de servicios.*/ 


            MenuInterfaz mi= new MenuImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();
            List<ClienteDto> listaClientes= new List<ClienteDto>();
            int opcion;
            bool cerrarMenu = false;


            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccion();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] se  cerrara el menu");
                        cerrarMenu= true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se añadira un cliente y se mostrara por pantalla");

                        oi.crearCliente(listaClientes);

                        foreach(ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;

                    case 2:
                        Console.WriteLine("[INFO] Se eliminara un cliente");

                        oi.eliminarCliente(listaClientes);

                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }

                        break;
                }
            }
        }
    }
}
