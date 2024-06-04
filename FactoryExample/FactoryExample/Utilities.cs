using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FactoryExample
{
    internal static class Utilities 
    {
        public static int generarOpcionesYResponse(string[] options) {
            int opt;
            bool successInp;
            Console.WriteLine();
            Console.WriteLine("Opciones");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
            }
            Console.WriteLine("Otra tecla) Cancelar");
            Console.WriteLine();
            Console.Write("Seleccione la accion que desea realizar: ");
            successInp = int.TryParse(Console.ReadLine(), out opt);
            Console.WriteLine();
            if (!successInp) opt = -1; 
            return opt -1;
        }

        public static IEmpleado pedirInputsAsignar(IEmpleado empleado)
        {

            Console.Write("Ingrese el nombre: ");
            empleado.nombre = Console.ReadLine();
            Console.Write("Ingrese su salario: ");
            empleado.salary = decimal.Parse(Console.ReadLine());
            return empleado;
        }
    }
}
