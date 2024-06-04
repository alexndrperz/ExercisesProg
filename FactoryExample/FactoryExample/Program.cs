
using FactoryExample;

internal class Program
{

    private static string[] tiposEmpleado = ["Empleado administrativo", "Empleado operativo", "Empleado gerencial"];
    private static void Main(string[] args)
    {
        string[] registerMenu = ["Mostrar empleados", "Registrar empleado", "Borrar empleado"];
        int opt;

        separator();
        Console.WriteLine("Bienvenido al gestor de nomina");
        separator();
        Console.WriteLine();

        do
        {
            separator();
            Console.WriteLine("Menu principal: ");
            opt = Utilities.generarOpcionesYResponse(registerMenu);
            switch (opt)
            {
                case 0:MostrarEmpleados();break;
                case 1:CrearEmpleado();break;
                case 2:EliminarEmpleado();break;;
            }

        } while (opt >= 0 && opt < registerMenu.Length);


        Console.WriteLine();

        Console.WriteLine("¡Gracias por su visita..!");

    }


    private static void CrearEmpleado()
    {
        Console.WriteLine("Seleccione el tipo de empleado que desea registrar: ");
        Console.WriteLine();
        int opt;
        do
        {
            opt = Utilities.generarOpcionesYResponse(tiposEmpleado);
            //if(opt ==0)

        } while (opt >= 0 && opt < tiposEmpleado.Length);

        Console.WriteLine();
    }

    private static void MostrarEmpleados()
    {
        Console.WriteLine("ss");
    }

    private static void EliminarEmpleado()
    {
        Console.WriteLine("asasa");
    }




    private static void separator()
    {
        Console.WriteLine("------------------------------------------------");
    }
}