﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal class EGerencial : IEmpleado
    {
        public decimal percentBono { get ; set ; }
        public decimal salary { get ; set ; }
        public decimal gananciaBono { get; set; }
        public string nombre { get ; set ; }

        public EGerencial()
        {
            percentBono = 50;
        }


        public string describir(bool paraTxt = false)
        {
            if (paraTxt)
            {
                return $" El Empleado Gerencial de: \n Nombre: {nombre} \n Salario: {salary} \n recibio un bono de {gananciaBono}";
            }
            else
            {
                return $"Nombre: {nombre} \n Salario: {salary}";
            }
        }

        public void pagarElBono()
        {
            gananciaBono = salary * (percentBono / 100);
        }


    }
}
