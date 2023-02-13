using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Class1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese sus apellidos");
            string apellidos = Console.ReadLine();

            Console.WriteLine(" Ingrese su genero");
            string genero = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Infrese su nacionalidad");
            string nacionalidad = Console.ReadLine();

            Console.WriteLine(" Bienvenido " + nombre + " " + apellidos + " su genero es " + genero + " su edad es de " + edad + " años " + " y su nacionalidas es " + nacionalidad);
            Console.ReadKey();
        }
    }
}
