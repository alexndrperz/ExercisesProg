using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal class EOperativo : IEmpleado
    {
        public decimal percentBono { get ; set ; }
        public decimal salary { get ; set ; }
        public string nombre { get ; set ; }
        public decimal gananciaBono { get; set; }

        public EOperativo()
        {
            percentBono = 10;
        }

        public string describir(bool paraTxt = false)
        {
            if (paraTxt)
            {
                return $" El Empleado Operativo de: \n Nombre: {nombre} \n Salario: {salary} \n recibio un bono de {gananciaBono}";
            }
            else
            {
                return $"Nombre: {nombre} \n Salario: {salary}";
            }
        }

        public void pagarElBono()
        {
            gananciaBono = salary * (percentBono /100);
        }

    }
}
