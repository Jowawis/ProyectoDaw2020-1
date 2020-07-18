using BL_Proyecto;
using DA_Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoDAWFINAL.Areas.Administrador.Controllers
{
    public class DonanteController : Controller
    {
        // GET: Administrador/Donante
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listado()
        {
            ViewBag.ListadoDonante = BLDonante.listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult Grabar(string nombreDonante, string apellidoDonante, string dniDonante, DateTime fecha, string direccionRecojo, string regionDonante, string provinciaDonante, string distritoDonante, string celularDonante, int codigoDonante)
        {
            Donante donante = new Donante();
            donante.nombre = nombreDonante;
            donante.apellido = apellidoDonante;
            donante.dni = dniDonante;
            donante.fecha = fecha;
            donante.direccion_recogo = direccionRecojo;
            donante.region = regionDonante;
            donante.provincia = provinciaDonante;
            donante.distrito = distritoDonante;
            donante.celular = celularDonante;

            bool exito = true;
            if (codigoDonante == -1)//NuevoRegistro
            {
                exito = BLDonante.registrar(donante);
            }
            else
            {
                donante.idDonante = codigoDonante;
                exito = BLDonante.actualizar(donante);
            }

            return Json(exito, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult Eliminar(int codigoDonante)
        {
            bool exito = BLDonante.eliminar(codigoDonante);
            return Json(exito, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult Editar(int codigoDonante)
        {
            Donante donante = new Donante();
            donante = BLDonante.obtener(codigoDonante);
            return Json(donante, JsonRequestBehavior.AllowGet);
        }
    }
}