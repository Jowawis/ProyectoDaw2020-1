using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Proyecto
{
    public class DADonante
    {

        public static List<Donante> listado()
        {
            using (var data = new ProyectoDawEntities())
            {
                return data.Donante.ToList();
                //return data.Donante.ToList<Donante>();
            }

        }
        public static Donante obtener(int donanteCodigo)
        {
            using (var data = new ProyectoDawEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Donante.Where(x => x.idDonante == donanteCodigo).FirstOrDefault();
            }
        }

        public static bool eliminar(int donanteCodigo)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Donante donante = data.Donante.Where(x => x.idDonante == donanteCodigo).FirstOrDefault();
                    data.Donante.Remove(donante);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        public static bool registrar(Donante donante)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    data.Donante.Add(donante);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        public static bool actualizar(Donante donante)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Donante donanteActual = data.Donante.Where(x => x.idDonante == donante.idDonante).FirstOrDefault();

                    donanteActual.nombre = donante.nombre;
                    donanteActual.apellido = donante.apellido;
                    donanteActual.dni = donante.dni;
                    donanteActual.fecha = donante.fecha;
                    donanteActual.direccion_recogo = donante.direccion_recogo;
                    donanteActual.region = donante.region;
                    donanteActual.provincia = donante.provincia;
                    donanteActual.distrito = donante.distrito;
                    donanteActual.celular = donante.celular;
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
