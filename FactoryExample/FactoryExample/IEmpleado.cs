using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal interface IEmpleado
    {
        string nombre { get; set; }
        decimal percentBono { get; set; }       
        decimal salary { get; set; }
        decimal gananciaBono { get; set; }

        string describir(bool paraTxt = false);
        void pagarElBono();

    }
}
