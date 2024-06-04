using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousGestorEdction
{
    internal class Diplomado : ICurso
    {
        public DateTime initDate { get; set; }
        public DateTime finalDate { get; set; }
        public int cupo { get; set; }
        public string teacher { get; set; }

        public string describir()
        {
            return $"Diplomado \n  Inicio: {initDate.ToString()} \n Final: {finalDate.ToString()} \n Cupo: {cupo} \n Maestro: {teacher} ";
        }

        public void registerData()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese cuando comienza el curso: ");
            initDate = Utilities.parseadorFecha();
            Console.WriteLine("Ingrese cuando finaliza: ");
            finalDate = Utilities.parseadorFecha();
            Console.Write("Ingrese cupo: ");
            cupo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese maestro: ");
            teacher = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
