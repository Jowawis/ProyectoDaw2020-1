using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Proyecto
{
    public class TriajeDA
    {
        public static List<Triaje_Digital> listado()
        {
            using (var data = new ProyectoDawEntities())
            {
                return data.Triaje_Digital.ToList();
            }
        }

        public static Triaje_Digital obtener(int idTriaje)
        {
            using (var data = new ProyectoDawEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Triaje_Digital.Where(x => x.idTriaje == idTriaje).FirstOrDefault();
            }

        }

        public static bool eliminar(int idTriaje)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Triaje_Digital triaje = data.Triaje_Digital.Where(x => x.idTriaje == idTriaje).FirstOrDefault();
                    data.Triaje_Digital.Remove(triaje);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        public static bool registrar(Triaje_Digital triaje)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    data.Triaje_Digital.Add(triaje);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        public static bool actualizar(Triaje_Digital triaje)
        {
            bool exito = true;
            try
            {
                using (var data = new ProyectoDawEntities())
                {
                    Triaje_Digital triajeActual = data.Triaje_Digital.Where(x => x.idTriaje == triaje.idTriaje).FirstOrDefault();

                    triajeActual.nombre = triaje.nombre;
                    triajeActual.apellido = triaje.apellido;
                    triajeActual.dni = triaje.dni;
                    triajeActual.sexo = triaje.sexo;
                    triajeActual.celular = triaje.celular;
                    triajeActual.region = triaje.region;
                    triajeActual.provincia = triaje.provincia;
                    triajeActual.distrito = triaje.distrito;
                    triajeActual.direccion = triaje.direccion;
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
