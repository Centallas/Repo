//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpleadoApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCHComponenteRol
    {
        public int IdComponenteRol { get; set; }
        public int IdComponente { get; set; }
        public int IdRol { get; set; }
        public int IdEvaluacion { get; set; }
        public Nullable<int> IdArea { get; set; }
        public Nullable<double> dblPeso { get; set; }
        public string strDocumentoFormacion { get; set; }
        public Nullable<bool> logEstado { get; set; }
    
        public virtual tblCHComponente tblCHComponente { get; set; }
    }
}
