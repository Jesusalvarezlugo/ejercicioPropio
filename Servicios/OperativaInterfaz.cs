using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using actividadPropia.Dtos;

namespace actividadPropia.Servicios
{
    internal interface OperativaInterfaz
    {
        public void crearCliente(List<ClienteDto> listaAntigua);

        public void eliminarCliente(List<ClienteDto> listaAntigua);
    }
}
