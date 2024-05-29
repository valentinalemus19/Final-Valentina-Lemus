using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPC
{
    internal class Libro
    {
        //Definición de las propiedades de libro
        public string titulo = "";
        public string autor = "";
        public string genero = "";
        public string disponibilidad = "";
        
        //Incialización de las propiedades de libro
       public Libro(string titulo, string autor, string genero, string disponibilidad) 
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.disponibilidad=disponibilidad;
        }

    }
}
