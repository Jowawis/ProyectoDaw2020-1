using DA_Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Proyecto
{
    public class PersonaExtrPobreBL
    {
        public static List<Personas_extrema_pobreza> listado()
        {
            return PersonaExtrPobreDA.listado();
        }

        public static Personas_extrema_pobreza obtener(int idPersPobreza)
        {
            return PersonaExtrPobreDA.obtener(idPersPobreza);
        }

        public static bool eliminar(int idPersoPobreza)
        {
            return PersonaExtrPobreDA.eliminar(idPersoPobreza);
        }

        public static bool registrar(Personas_extrema_pobreza perso_Extr_pobr)
        {
            return PersonaExtrPobreDA.registrar(perso_Extr_pobr);
        }

        public static bool actualizar(Personas_extrema_pobreza perso_Extr_pobr)
        {
            return PersonaExtrPobreDA.actualizar(perso_Extr_pobr);
        }



    }
}
