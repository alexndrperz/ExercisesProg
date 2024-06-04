using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal static  class Creator
    {
        public static IEmpleado crearInstanciaEmpleado(int empleadoId)
        {
            switch (empleadoId)
            {
                case 1: return new EAdministrativo();
                case 2: return new EGerencial();
                case 3: return new EOperativo();
                default: return null;
                    
            }
        }
    }
}
