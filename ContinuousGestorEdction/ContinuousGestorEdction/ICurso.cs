using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousGestorEdction
{
    internal interface ICurso
    {

        DateTime initDate { get; set; } 
        DateTime finalDate { get; set; }    
        int cupo { get; set; }  
        string teacher { get; set; }


        void registerData();
        string describir();
    }
}
