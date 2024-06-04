
using FactoryExample;

internal class Program
{

    private static string[] tiposEmpleado = ["Empleado administrativo", "Empleado gerencial", "Empleado operativo"];

    private static List<IEmpleado> empleadosList = new List<IEmpleado>();
    private static void Main(string[] args)
    {
        string[] registerMenu = ["Mostrar empleados", "Registrar empleado", "Borrar empleado", "Aplicar Bono"];
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
                case 0: MostrarEmpleados(); break;
                case 1: CrearEmpleado(); break;
                case 2: EliminarEmpleado(); break; 
                case 3: PagarBono();break;
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
            if (opt >= 0 && opt < tiposEmpleado.Length)
            {
                IEmpleado empleado = Creator.crearInstanciaEmpleado(opt + 1);
                Utilities.pedirInputsAsignar(empleado);
                empleadosList.Add(empleado);
                Console.WriteLine("Empleado Añadido exitosamente..!!");


            }

        } while (opt >= 0 && opt < tiposEmpleado.Length);

        Console.WriteLine();
    }

    private static void MostrarEmpleados()
    {
        if (empleadosList.Count == 0)
        {
            Console.WriteLine("No tiene empleados");
        }
        int id = 0;
        foreach (var item in empleadosList)
        {
            id++;
            separator();
            Console.WriteLine($"Id: {id}");
            Console.WriteLine(item.describir());
            separator();
        }
    }

    private static void EliminarEmpleado()
    {
        Console.Write("Ingrese el id del empleado: ");
        int idEmp = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if(idEmp-1 < empleadosList.Count)
        {

        empleadosList.RemoveAt(idEmp-1);
            Console.WriteLine("Borrado exitosamente");
        } else
        {
            Console.WriteLine("El id no existe");
        }

    }

    private static void PagarBono()
    {
        Console.WriteLine("Pagando y haciendo registro del bono de cada empleado: ");
        if(empleadosList.Count == 0) {
            Console.WriteLine("No tiene empleados");
        }
        foreach (var item in empleadosList)
        {
            item.pagarElBono();
            TXTRegister.Instances.logToTxt(item.describir(true));
        }
        Console.WriteLine("Bonos pagados y listos, revise su db.txt");
    }




    private static void separator()
    {
        Console.WriteLine("------------------------------------------------");
    }
}