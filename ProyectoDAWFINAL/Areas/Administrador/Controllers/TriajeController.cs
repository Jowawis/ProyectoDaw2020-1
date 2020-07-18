using BL_Proyecto;
using DA_Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoDAWFINAL.Areas.Administrador.Controllers
{
    public class TriajeController : Controller
    {
        // GET: Administrador/Triaje
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Listado()
        {
            ViewBag.ListadoTriaje = TriajeBL.listado();
            return PartialView();
        }

        [HttpPost]

        public JsonResult Grabar(
                string nombretriaje,
                string apellidotriaje,
                string dnitriaje,
                string sexotriaje,
                string celulartriaje,
                string regiontriaje,
                string provinciatriaje,
                string distritotriaje,
                string direcciontriaje,
                int idtriaje)

        {
            Triaje_Digital triaje = new Triaje_Digital();
            triaje.nombre = nombretriaje;
            triaje.apellido = apellidotriaje;
            triaje.dni = dnitriaje;
            triaje.sexo = sexotriaje;
            triaje.celular = celulartriaje;
            triaje.region = regiontriaje;
            triaje.provincia = provinciatriaje;
            triaje.distrito = distritotriaje;
            triaje.direccion = direcciontriaje;

            bool exito = true;
            if (idtriaje == -1)//Es un nuevo registro
            {
                exito = TriajeBL.registrar(triaje);
            }
            else // Es una actualización
            {
                triaje.idTriaje = idtriaje;
                exito = TriajeBL.actualizar(triaje);
            }

            return Json(exito, JsonRequestBehavior.AllowGet);


        }

        [HttpPost]

        public JsonResult Eliminar(int idtriaje)
        {
            bool exito = TriajeBL.eliminar(idtriaje);
            return Json(exito, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]

        public JsonResult Editar(int idtriaje)
        {
            Triaje_Digital triaje = new Triaje_Digital();
            triaje = TriajeBL.obtener(idtriaje);
            return Json(triaje, JsonRequestBehavior.AllowGet);
        }
    }

}