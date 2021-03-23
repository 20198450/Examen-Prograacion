using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Saludo(" Manuel  ", " Medina ", "  Cedula: 001-0019247-2  ", " Eada: 37 "));
            Console.ReadKey();
        }

        static string Saludo(String nombre)
        { 
            return "Hola Sr." + nombre + "!";
       
        }

        static string Saludo(string nombre, string apellido) 
        {

            return Saludo(nombre + "" + apellido);

        }

        static string Saludo(string nombre, string apellido, string Cedula, string Edad) 
        {

            return Saludo(nombre + "" + apellido  + Cedula + Edad);
        }


    }

         
}
