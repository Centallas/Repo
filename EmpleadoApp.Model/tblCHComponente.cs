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
    
    public partial class tblCHComponente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCHComponente()
        {
            this.tblCHComponenteRol = new HashSet<tblCHComponenteRol>();
        }
    
        public int IdComponente { get; set; }
        public string strNombreComponente { get; set; }
        public string strDescripcionComponente { get; set; }
        public Nullable<double> dblPesoComponente { get; set; }
        public Nullable<bool> logActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCHComponenteRol> tblCHComponenteRol { get; set; }
    }
}