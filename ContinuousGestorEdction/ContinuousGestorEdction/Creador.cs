using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousGestorEdction
{
    internal static class Creador
    {
        public static ICurso createInstanceCourse(int courseId)
        {
            switch (courseId)
            {
                case 1: return new Diplomado();
                case 2: return new Seminarios();
                case 3: return new Talleres();
                default:return null;
            } 
        }
    }
}
