//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pregunta2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.deducciones = new HashSet<deducciones>();
        }
    
        public int codigo_empleado { get; set; }
        public string Nombre { get; set; }
        public decimal Horas_laboradas { get; set; }
        public decimal Salario_Hora { get; set; }
        public decimal Salario_Bruto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<deducciones> deducciones { get; set; }
    }
}
