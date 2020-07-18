using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Proyecto
{
    public class DADonacion
    {
        public static List<Donacion> listado()
        {
            using (var data = new ProyectoDawEntities())
            {
                return data.Donacion.ToList<Donacion>();
            }

        }
        public static Donacion obtener(int donacionCodigo)
        {
            using (var data = new ProyectoDawEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Donacion.Where(x => x.idDonacion == donacionCodigo).FirstOrDefault();
            }
        }

        public static bool eliminar(int donacionCodigo)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Donacion donacion = data.Donacion.Where(x => x.idDonacion == donacionCodigo).FirstOrDefault();
                    data.Donacion.Remove(donacion);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        public static bool registrar(Donacion donacion)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    data.Donacion.Add(donacion);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        public static bool actualizar(Donacion donacion)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Donacion donacionActual = data.Donacion.Where(x => x.idDonacion == donacion.idDonacion).FirstOrDefault();

                    donacionActual.idPobreza = donacion.idPobreza;
                    donacionActual.descripcion = donacion.descripcion;
                    donacionActual.tipo = donacion.tipo;
                    donacionActual.cantidad = donacion.cantidad;
                    donacionActual.estado = donacion.estado;
                    donacionActual.fecha_recojo = donacion.fecha_recojo;
                    donacionActual.idDonante = donacion.idDonante;
                    donacionActual.fecha_entrega = donacion.fecha_entrega;
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
