//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesion()
        {
            this.EmpleadoEdificioProfesions = new HashSet<EmpleadoEdificioProfesion>();
        }
    
        public int Profesion_Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> TipoProfesion_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoEdificioProfesion> EmpleadoEdificioProfesions { get; set; }
        public virtual TipoProfesional TipoProfesional { get; set; }
    }
}
