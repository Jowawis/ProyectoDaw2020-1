using DA_Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Proyecto
{
    public class BLDonante
    {
        public static List<Donante> listado()
        {
            return DADonante.listado();
        }

        public static Donante obtener(int donanteCodigo)
        {
            return DADonante.obtener(donanteCodigo);
        }

        public static bool eliminar(int donanteCodigo)
        {
            return DADonante.eliminar(donanteCodigo);
        }

        public static bool registrar(Donante donante)
        {
            return DADonante.registrar(donante);
        }

        public static bool actualizar(Donante donante)
        {
            return DADonante.actualizar(donante);
        }

    }
}
