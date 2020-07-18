using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Proyecto
{
    public class PersonaExtrPobreDA
    {
        /// <summary>
        /// Listado de personas extrema pobreza
        /// </summary>
        /// <returns></returns>
        public static List<Personas_extrema_pobreza> listado()
        {
            using (var data = new ProyectoDawEntities())
            {
                return data.Personas_extrema_pobreza.ToList();
            }

        }

        /// <summary>
        /// Se obtiene una persona
        /// </summary>
        /// <param name="idPersPobreza"></param>
        /// <returns></returns>
        public static Personas_extrema_pobreza obtener(int idPersPobreza)
        {
            using (var data = new ProyectoDawEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Personas_extrema_pobreza.Where(x => x.idPobreza == idPersPobreza).FirstOrDefault();
            }
        }

        public static bool eliminar (int idPersoPobreza)
        {
            bool exito = true;
            try
            {
                using(var data = new ProyectoDawEntities())
                {
                    Personas_extrema_pobreza personaExtrPobre= data.Personas_extrema_pobreza.Where(x => x.idPobreza == idPersoPobreza).FirstOrDefault();
                    data.Personas_extrema_pobreza.Remove(personaExtrPobre);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;

        }

        public static bool registrar (Personas_extrema_pobreza perso_Extr_pobr)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    data.Personas_extrema_pobreza.Add(perso_Extr_pobr);
                    data.SaveChanges();

                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        public static bool actualizar (Personas_extrema_pobreza perso_Extr_pobr)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Personas_extrema_pobreza personas_Extrema_Pobreza = data.Personas_extrema_pobreza.Where(x => x.idPobreza == perso_Extr_pobr.idPobreza).FirstOrDefault();
                    personas_Extrema_Pobreza.nombre = perso_Extr_pobr.nombre;
                    personas_Extrema_Pobreza.apellido = perso_Extr_pobr.apellido;
                    personas_Extrema_Pobreza.dni= perso_Extr_pobr.dni;
                    personas_Extrema_Pobreza.region= perso_Extr_pobr.region;
                    personas_Extrema_Pobreza.provincia= perso_Extr_pobr.provincia;
                    personas_Extrema_Pobreza.distrito= perso_Extr_pobr.distrito;
                    personas_Extrema_Pobreza.direccion= perso_Extr_pobr.direccion;
                    personas_Extrema_Pobreza.necesidad= perso_Extr_pobr.necesidad;
                    data.SaveChanges();

                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

    }
}
