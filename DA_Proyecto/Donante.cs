//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA_Proyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donante()
        {
            this.Donacion = new HashSet<Donacion>();
        }
    
        public int idDonante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string direccion_recogo { get; set; }
        public string region { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string celular { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donacion> Donacion { get; set; }
    }
}
