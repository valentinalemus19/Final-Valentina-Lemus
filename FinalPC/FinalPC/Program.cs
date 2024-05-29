using FinalPC;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        Usuario [] usuario;
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("      Bienvenido a Biblioteca virtual URL       ");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");
        string opcion2 = " "; //Variable empleada para el regreso al menú principal

        do
        {

            string opcion = " ";
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                    Menu de opciones            ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("a) Ingreso de datos personales");
            Console.WriteLine("b) Mostrar datos");
            Console.WriteLine("c) Salir del programa");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Ingrese la accion que desea ejecutar");
            opcion = Console.ReadLine();
            Console.WriteLine("");
            while (!opcion.All(char.IsLetter)) //Valida el parámetro ingresado es un valor alfabético
            {
                Console.WriteLine("Parámetro no válido");
                Console.WriteLine("Ingrese la accion que desea ejecutar");
                opcion = Console.ReadLine();
            }

            switch (opcion) //ciclo switch para la ejecución de las funciones
            {
                case "a":
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("    Usted ha elegido el registro de usuarios    ");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");

                    string nombre = "";
                    string apellido = "";
                    String carne = "" ;
                    string telefono = "";
                    bool actividad = false;
                    int N = 0;
                    Console.WriteLine("Ingrese la cantidad de usuarios que desea registrar");
                    N = int.Parse(Console.ReadLine());
                    usuario = new Usuario[N]; //Arreglo de N cantidad de usuarios que se desean registrar
                    for (int i = 0; i < N; i++) //Ciclo for que recorre todo el arreglo
                    {
                        Console.WriteLine("Ingrese nombre");
                        nombre = Console.ReadLine();
                        while (!nombre.All(char.IsLetter)) //Validar que los parámetros de nombre sean solo alfabéticos.
                        {
                            Console.WriteLine("Parámetro no válido");
                            Console.WriteLine("Ingrese nombre");
                            nombre = Console.ReadLine();
                        }
                        Console.WriteLine("Ingrese apellido");
                        apellido = Console.ReadLine();
                        while (!apellido.All(char.IsLetter)) //Validar que los parámetros de apellido sean solo alfabéticos.
                        {
                            Console.WriteLine("Parámetro no válido");
                            Console.WriteLine("Ingrese apellido");
                            apellido = Console.ReadLine();
                        }
                        Console.WriteLine("Ingrese carne (7 carácteres para ser válido)");
                        carne = Console.ReadLine();
                        while (carne.Length != 7) //Validar que carné contenga estrictamente 7 carácteres
                        {
                            Console.WriteLine("Parámetro no válido");
                            Console.WriteLine("Ingrese carne");
                            carne = Console.ReadLine();
                        }
                        Console.WriteLine("Ingrese telefono (8 carácteres para ser válido)");
                        telefono = Console.ReadLine();
                        while (telefono.Length != 8) // Validar que teléfino contenga estrictamente 8 carácteres
                        {
                            Console.WriteLine("Parámetro no válido");
                            Console.WriteLine("Ingrese telefono");
                            telefono = Console.ReadLine();
                        }
                        Console.WriteLine("El usuario es activo? Si = 1 / No = 0");
                        int respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1) 
                        {
                            actividad = true; // Si el usuario está activo, la función es verdadera.
                            Console.WriteLine("Usuario Activo");
                        }
                        else if (respuesta == 0)
                        {
                            actividad = false; // Si el usuario no está activo, la función es falsa.
                            Console.WriteLine("Usuario No Activo");

                        }
                        else
                        {
                            Console.WriteLine("Parámetro no válido"); //Al ingresar un parámetro diferente de 1 y 0, no será válido.
                        }
                        usuario[i] = new Usuario(nombre, apellido, carne, telefono, actividad); //Indica la posición del usuario dentro del arreglo.
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("                    Usuario                     ");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine($"Nombre: {usuario[i].nombre}"); 
                        Console.WriteLine($"Apellido: {usuario[i].apellido}");
                        Console.WriteLine($"Carne: {usuario[i].carne}");
                        Console.WriteLine($"Telefono: {usuario[i].telefono}");
                        Console.WriteLine("------------------------------------------------");
                        //Impresión de los datos de la N cantidad de usuarios.



                    }
                    break;
                case "b":
                    string opcion3 = "";
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("         Usted ha elegido mostrar datos         ");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("                 Menu de opciones               ");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("a.) Consultar biblioteca");
                    Console.WriteLine("b.) Consultar catalogo de libros");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Ingrese la accion que desea ejecutar");
                    opcion3 = Console.ReadLine();
                    while (!opcion3.All(char.IsLetter)) //Validar que los parámetros de opcion3 sean solo alfabéticos.
                    {
                        Console.WriteLine("Parámetro no válido");
                        Console.WriteLine("Ingrese la accion que desea ejecutar");
                        opcion3 = Console.ReadLine();

                    }
                    switch (opcion3) //Si cumple con la condición de ser solamente parámetros alfabéticos, entonces desplegará un menú interactivo.
                    {
                        case "a":
                            Console.WriteLine("");
                            Console.WriteLine("");

                            string opcion4 = "";
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("             Consultar biblioteca               ");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("a.) Prestar libros"); 
                            Console.WriteLine("b.) Delvolver libros");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Ingrese la accion que desea ejecutar");
                            opcion4 = Console.ReadLine();
                            while (!opcion4.All(char.IsLetter)) //Validar que los parámetros de opcion4 sean solo alfabéticos.
                            {
                                Console.WriteLine("Parámetro no válido");
                                Console.WriteLine("Ingrese la accion que desea ejecutar");
                                opcion4 = Console.ReadLine();

                            }
                            switch (opcion4)  //Si cumple con la condición de ser solamente parámetros alfabéticos, entonces desplegará un menú interactivo.
                            {
                                case "a":
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    int cantidad = 0;
                                    string libro = "";
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("                Prestar Libros                  ");
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("Ingrese la cantidad de libros que desea prestar:");
                                    cantidad = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < cantidad; i++) //Ciclo que recorre la cantidad de libros que el usuario desea prestar.
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("");

                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("                     Libros                     ");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine($"a.)  {biblioteca.objlibro[0].titulo}"); //Despliegue del menú de libros.
                                        Console.WriteLine($"b.)  {biblioteca.objlibro[1].titulo}");
                                        Console.WriteLine($"c.)  {biblioteca.objlibro[2].titulo}");
                                        Console.WriteLine($"d.)  {biblioteca.objlibro[3].titulo}");
                                        Console.WriteLine($"e.)  {biblioteca.objlibro[4].titulo}");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese la opcion del libro que desea prestar: ");
                                        libro = Console.ReadLine();
                                        while (!libro.All(char.IsLetter)) //Validar que los parámetros de libro sean solo alfabéticos.
                                        {
                                            Console.WriteLine("Parámetro no válido");
                                            Console.WriteLine("Ingrese la opcion del libro que desea prestar: ");
                                            libro = Console.ReadLine();
                                        }
                                        switch(libro)  //Si cumple con la condición de ser solamente parámetros alfabéticos, entonces desplegará un menú interactivo.
                                        {
                                            case "a":
                                                Console.WriteLine($"Usted ha prestado {biblioteca.objlibro[0].titulo} ");
                                                break;
                                            case "b":
                                                Console.WriteLine($"Usted ha prestado {biblioteca.objlibro[1].titulo} ");

                                                break;
                                            case "c":
                                                Console.WriteLine($"Usted ha prestado {biblioteca.objlibro[2].titulo} ");

                                                break;
                                            case "d":
                                                Console.WriteLine($"Usted ha prestado {biblioteca.objlibro[3].titulo} ");

                                                break;
                                            case "e":
                                                Console.WriteLine($"Usted ha prestado {biblioteca.objlibro[4].titulo} ");

                                                break;
                                            default:
                                                Console.WriteLine("Opcion no válida");
                                                break;
                                        }
                                        

                                    }

                                    break;

                                case "b":
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    int cantidad2 = 0;
                                    string devolucion = "";
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("                Devolver Libros                 ");
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Ingrese la cantidad de libros que desea devolver:");
                                    cantidad = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < cantidad; i++) //Ciclo que recorreo la cantidad de libros que el usuario desea devolver.
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("                    Libros                      ");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine($"a.)  {biblioteca.objlibro[0].titulo}");
                                        Console.WriteLine($"b.)  {biblioteca.objlibro[1].titulo}");
                                        Console.WriteLine($"c.)  {biblioteca.objlibro[2].titulo}");
                                        Console.WriteLine($"d.)  {biblioteca.objlibro[3].titulo}");
                                        Console.WriteLine($"e.)  {biblioteca.objlibro[4].titulo}");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese la opcion del libro que desea devolver: ");
                                        devolucion = Console.ReadLine();
                                        while(!devolucion.All(char.IsLetter)) //Validar que los parámetros de devolucion sean solo alfabéticos.
                                        {
                                            Console.WriteLine("Parámetro no válido");
                                            Console.WriteLine("Ingrese la opcion del libro que desea devolver: ");
                                            devolucion = Console.ReadLine();

                                        }
                                        switch (devolucion) //Si cumple con la condición de ser solamente parámetros alfabéticos, entonces desplegará un menú interactivo.
                                        {
                                            case "a":
                                                Console.WriteLine($"Usted ha devuelto {biblioteca.objlibro[0].titulo} ");
                                                break;
                                            case "b":
                                                Console.WriteLine($"Usted ha devulto {biblioteca.objlibro[1].titulo} ");

                                                break;
                                            case "c":
                                                Console.WriteLine($"Usted ha devuelto {biblioteca.objlibro[2].titulo} ");

                                                break;
                                            case "d":
                                                Console.WriteLine($"Usted ha devuelto {biblioteca.objlibro[3].titulo} ");

                                                break;
                                            case "e":
                                                Console.WriteLine($"Usted ha devuelto {biblioteca.objlibro[4].titulo} ");

                                                break;
                                            default:
                                                Console.WriteLine("Opcion no válida");
                                                break;
                                        }


                                    }
                                    break;
                                default:
                                    Console.WriteLine("");

                                    Console.WriteLine("Opción no válida"); //Todo parámetro diferente de a y b, no será valido.
                                    break ;


                            }
                            break;
                        case "b":
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("          Consultar catalogo de libros          ");
                            Console.WriteLine("------------------------------------------------");
                            biblioteca.MostrarLibros(); //función que muestra el catálogo de libros.
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Opcion no válida"); //Todo parámetro diferente de a, b y c, será no válida.
                            break;

                    }

                    break;
                case "c":
                    Console.WriteLine("Fin del programa");


                    break;
                default:
                    Console.WriteLine("Opcion no válida");
                    break;

            }




            Console.WriteLine("Desea volver al menu interactivo? Si = a / No = b"); //Opción que permite regresar al menú principal las veces que el usuario desea.
            opcion2 = Console.ReadLine();
            while (!opcion2.All(char.IsLetter)) //Validar que el parámetro de opcion2 sea estrictamente alfabético. 
            {
                Console.WriteLine("Parámetro no válido");
                Console.WriteLine("Desea volver al menu interactivo? Si = a / No = b");
                opcion2 = Console.ReadLine();

            }
            
        } while (opcion2 == "a");

        Console.WriteLine("Fin del programa");
    }

}

