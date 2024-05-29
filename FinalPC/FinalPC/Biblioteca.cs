using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalPC
{
    internal class Biblioteca
    {
        public Libro[] objlibro = new Libro[5]; //Arreglo de la cantidad de libros del catálogo.

        public Biblioteca()
        {

            //Definición del título, autor, género y disponibilidad de cada libro.
            objlibro[0] = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "Satira", "Disponible");
            objlibro[1] = new Libro("El código Da Vinci", "Dan Brown", "Ficción Conspirativa", "Disponible");
            objlibro[2] = new Libro("Diez negritos", "Agatha Christie", "Misterio", "Disponible");
            objlibro[3] = new Libro("Alicia en el país de las maravillas", "Lewis Carroll", "Fantasía", "Disponible");
            objlibro[4] = new Libro("Las aventuras de Sherlock Holmes", "Arthur Conan Doyle", "Misterio", "Disponible");


        }
        public void MostrarLibros() //Función empleada para moestrar el catálogo de libros.
        {
            for (int i = 0; i < objlibro.Length; i++)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Nombre: {objlibro[i].titulo}");
                Console.WriteLine($"Autor: {objlibro[i].autor}");
                Console.WriteLine($"Género: {objlibro[i].genero}");
                Console.WriteLine($"Disponibilidad: {objlibro[i].disponibilidad}");
                Console.WriteLine("------------------------------------------------");


            }
        }


    }

}
