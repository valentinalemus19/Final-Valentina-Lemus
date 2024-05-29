using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPC
{
    internal class Usuario
    {
        //Definición de las propiedades de usuario
        public string nombre = " ";
        public string apellido = " ";
        public string carne = "";
        public string telefono = "";
        public bool actividad = false;

        //Inicialización de las propiedades de usuario
        public Usuario(string nombre, string apellido, string carne, string telefono, bool actividad) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.carne = carne;
            this.telefono = telefono;
            this.actividad = actividad;
        }


    }
}
