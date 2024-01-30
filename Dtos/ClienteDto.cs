using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadPropia.Dtos
{
    internal class ClienteDto
    {
        //Atributos

        long id;
        string nombre="aaaaa";
        string apellidos="aaaaa";
        string dni= "aaaaa";
        string telefono = "aaaaa";

      

        //GETTERS Y SETTERS
        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        //Constructores

        public ClienteDto()
        {

        }
        public ClienteDto(long id, string nombre, string apellidos, string dni, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
        }

        //Metodo ToString
        override
        public string ToString()
        {
            string texto = "Nombre: "+this.Nombre+"\nDNI: "+this.Dni;
            return texto;
        }

    }
}
