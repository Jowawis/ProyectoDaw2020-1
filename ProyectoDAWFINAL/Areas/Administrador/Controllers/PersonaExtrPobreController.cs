using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL_Proyecto;
using DA_Proyecto;

namespace ProyectoDAWFINAL.Areas.Administrador.Controllers
{
    public class PersonaExtrPobreController : Controller
    {
        // GET: Administrador/PersonaExtrPobre
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Listado()
        {
            ViewBag.ListadoPersonaExtremPobre = PersonaExtrPobreBL.listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult grabar(string nombrePobre, int CodPobreza, string apePobre, string dniPobre, string regPobre, string provPobre, string distPobre, string dirPobre, string necesidadPobre)
        {
            Personas_extrema_pobreza persona_extrm_pobre = new Personas_extrema_pobreza();
            persona_extrm_pobre.nombre = nombrePobre;
            persona_extrm_pobre.apellido = apePobre;
            persona_extrm_pobre.dni = dniPobre;
            persona_extrm_pobre.region = regPobre;
            persona_extrm_pobre.provincia = provPobre;
            persona_extrm_pobre.distrito = distPobre;
            persona_extrm_pobre.direccion = dirPobre;
            persona_extrm_pobre.necesidad = necesidadPobre;
            bool exito = true;
            if(CodPobreza ==-1)//nuevo registro
            {
                exito = PersonaExtrPobreBL.registrar(persona_extrm_pobre);

            }
            else //actualizacion
            {
                persona_extrm_pobre.idPobreza = CodPobreza;
                exito = PersonaExtrPobreBL.actualizar(persona_extrm_pobre);
            }
            return Json(exito,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Eliminar(int CodPobreza)
        {
            bool exito = PersonaExtrPobreBL.eliminar(CodPobreza);
            return Json(exito, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Editar(int CodPobreza)
        {
            Personas_extrema_pobreza persona_extrm_pobre = new Personas_extrema_pobreza();
            persona_extrm_pobre = PersonaExtrPobreBL.obtener(CodPobreza);
            return Json(persona_extrm_pobre, JsonRequestBehavior.AllowGet);
        }
    }
}