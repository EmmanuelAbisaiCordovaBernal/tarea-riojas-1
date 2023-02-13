using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1._1
{
    class Class1
    {
        static void main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine(" Bienvenido " + nombre + apellidos + " su edad es de " + edad + " años ");
            Console.ReadKey();
        }
    }
}
