using EF_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_7.Controllers
{
    public class CabeceraFrasController : Controller
    {
        static string FECHAFRA;
        static string SERIE;
        
        CabeceraFras factura = new CabeceraFras();
        // GET: CabeceraFras
        public ActionResult Index(string Serie, string fechafra)
        {
            SERIE = Serie;
            ViewBag.Serie = Serie;

            IVANN_Entities db = new IVANN_Entities();
            //CabeceraFras fra = new CabeceraFras();
            //fra.IDPACIENTE = Convert.ToInt32(IDPACIENTE);
            //fra.FECHA = Convert.ToDateTime(fechafra);
            //Pacientes paci = new Pacientes();
            //paci = db.Pacientes.Find(IDPACIENTE);
            //fra.NOMBRE_Y_APELLIDOS = paci.NOMBRE_Y_APELLIDOS;
            //fra.Nº_FACTURA = "";
            //fra.DNI = paci.DNI;
            //fra.TOTAL = 0;
            //fra.IDLINEAFRA = 0;
            Pacientes paciente = new Pacientes();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            Pacientes pacien = new Pacientes();
            //string se = SERIE;
            ////ViewBag.Serie = SERIE.ToString();
            return View(PACI_FRA);
        }
        [HttpPost]
        public ActionResult Index(CabFrasGlobal model)
        {
            string serie = SERIE;
            ViewBag.Serie = SERIE.ToString();
            IVANN_Entities db = new IVANN_Entities();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            Pacientes paciente = new Pacientes();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            Pacientes pacien = new Pacientes();
            pacien = db.Pacientes.Find(model.IDPACIENTE);
            CabeceraFras nuevafra = new CabeceraFras();
            nuevafra.IDPACIENTE = model.IDPACIENTE;
            nuevafra.FECHA = Convert.ToDateTime(FECHAFRA);
            nuevafra.TOTAL = model.TOTAL;
            nuevafra.NOMBRE_Y_APELLIDOS = pacien.NOMBRE_Y_APELLIDOS;
            nuevafra.DNI = pacien.DNI;
            nuevafra.Nº_FACTURA = "";
            //PACI_FRA.factura.IDPACIENTE = Convert.ToInt32(model.IDPACIENTE);
            
            return View(PACI_FRA);
            
        }
        public ActionResult Grabar(string id)
        {
            return View();
        }

    }
}