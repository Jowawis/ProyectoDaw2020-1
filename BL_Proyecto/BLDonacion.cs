using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA_Proyecto;
using System.Threading.Tasks;

namespace BL_Proyecto
{
    public class BLDonacion
    {
        public static List<Donacion> listado()
        {
            return DADonacion.listado();
        }

        public static Donacion obtener(int donacionCodigo)
        {
            return DADonacion.obtener(donacionCodigo);
        }

        public static bool eliminar(int donacionCodigo)
        {
            return DADonacion.eliminar(donacionCodigo);
        }

        public static bool registrar(Donacion donacion)
        {
            return DADonacion.registrar(donacion);
        }

        public static bool actualizar(Donacion donacion)
        {
            return DADonacion.actualizar(donacion);
        }
    }
}
