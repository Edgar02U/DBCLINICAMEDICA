//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_INVENTARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_INVENTARIO()
        {
            this.INVENTARIO = new HashSet<INVENTARIO>();
        }
    
        public int ID_TIPO_INVENTARIO { get; set; }
        public string NOMBRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO> INVENTARIO { get; set; }
    }
}