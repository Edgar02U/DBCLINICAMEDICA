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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.ROL_OPERACION = new HashSet<ROL_OPERACION>();
        }
    
        public int ID_USUARIO { get; set; }
        public string PRIMER_NOMBRE { get; set; }
        public string SEGUNDO_NOMBRE { get; set; }
        public string PRIMER_APELLIDO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public string USERC { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> EDAD { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string ESTADO { get; set; }
        public string PUESTO { get; set; }
        public string GENERO { get; set; }
        public Nullable<int> ID_SUCURSAL { get; set; }
    
        public virtual SUCURSAL SUCURSAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROL_OPERACION> ROL_OPERACION { get; set; }
    }
}
