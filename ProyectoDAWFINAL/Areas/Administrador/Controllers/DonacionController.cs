using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL_Proyecto;
using DA_Proyecto;

namespace ProyectoDAWFINAL.Areas.Administrador.Controllers
{
    public class DonacionController : Controller
    {
        // GET: Administrador/Donacion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Listado()
        {
            ViewBag.ListadoDonacion = BLDonacion.listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult Grabar(int idDonacion, int idPobreza, string descripcion, string tipo, string cantidad, int idDonante, string estado, string recojo, string entrega)
        {
            Donacion donacion = new Donacion();
            donacion.idPobreza = idPobreza;
            donacion.descripcion = descripcion;
            donacion.tipo = tipo;
            donacion.cantidad = cantidad;
            donacion.estado = estado;
            donacion.fecha_entrega = Convert.ToDateTime(entrega);
            donacion.fecha_recojo = Convert.ToDateTime(recojo);
            donacion.idDonante = idDonante;
            bool exito = true;
            if (idDonacion == -1)
            {
                exito = BLDonacion.registrar(donacion);
            }
            else
            {
                donacion.idDonacion = idDonacion;
                exito = BLDonacion.actualizar(donacion);
            }

            return Json(exito, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Eliminar(int codigoDonacion)
        {
            bool exito = BLDonacion.eliminar(codigoDonacion);
            return Json(exito, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Editar(int codigoDonacion)
        {
            Donacion donacion = new Donacion();
            donacion = BLDonacion.obtener(codigoDonacion);
            return Json(donacion, JsonRequestBehavior.AllowGet);
        }
    }
}