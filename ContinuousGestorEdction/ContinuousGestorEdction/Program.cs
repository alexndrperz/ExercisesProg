using ContinuousGestorEdction;

internal class Program
{

    private static string[] tipoCursos = ["Diplomado", "Taller", "Seminario"];
    private static void Main(string[] args)
    {



        separator();
        Console.WriteLine("¡Bienvenido a gestor continua!");
        separator();
        Console.WriteLine();

        string[] opciones = ["Registrar Curso"];
        int opt;
        do
        {
            opt = Utilities.generarOpcionesYResponse(opciones);

            switch (opt) {
                case 0:  registrarCurso();break;   
            }

        } while (opt >= 0 && opt < opciones.Length);

    }

    private static void registrarCurso() {
        Console.WriteLine();
        Console.WriteLine("Cual curso desea añadir..?");
        int opt = Utilities.generarOpcionesYResponse(tipoCursos);   
        ICurso curso = Creador.createInstanceCourse(opt+1);
        curso.registerData();


        TXTRegister.Instances.logToTxt(curso.describir());

    }

    private static void separator()
    {
        Console.WriteLine("-------------------------------------------------");
    }
}

// Me da la sensacion de que el profe pedira algo con json asi que

//https://www.educative.io/answers/how-to-read-a-json-file-in-c-sharp