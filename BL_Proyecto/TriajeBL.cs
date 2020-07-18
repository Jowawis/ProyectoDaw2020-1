using DA_Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Proyecto
{
    public class TriajeBL
    {
        public static List<Triaje_Digital> listado()
        {
            return TriajeDA.listado();
        }

        public static Triaje_Digital obtener(int idTriaje)
        {
            return TriajeDA.obtener(idTriaje);
        }

        public static bool eliminar(int idTriaje)
        {
            return TriajeDA.eliminar(idTriaje);
        }

        public static bool registrar(Triaje_Digital triaje)
        {
            return TriajeDA.registrar(triaje);
        }

        public static bool actualizar(Triaje_Digital triaje)
        {
            return TriajeDA.actualizar(triaje);
        }
    }
}
