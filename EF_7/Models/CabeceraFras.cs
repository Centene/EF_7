//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CabeceraFras
    {
        public int IDLINEAFRA { get; set; }
        public int IDPACIENTE { get; set; }
        public string NOMBRE_Y_APELLIDOS { get; set; }
        public string DNI { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string Nº_FACTURA { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    
        public virtual Pacientes Pacientes { get; set; }
    }
}
