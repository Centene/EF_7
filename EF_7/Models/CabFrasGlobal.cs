﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_7.Models
{
    public class CabFrasGlobal
    {
        public List<CabeceraFras> FacturasGlob = new List<CabeceraFras>();
        public List<Pacientes> PacientesGlob = new List<Pacientes>();
        public Pacientes paciente = new Pacientes();
        public CabeceraFras factura = new CabeceraFras();
        public Nullable<decimal> TOTAL { get; set; }
        public int IDPACIENTE { get; set; }
    }
}