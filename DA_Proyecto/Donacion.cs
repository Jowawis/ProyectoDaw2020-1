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
    
    public partial class Donacion
    {
        public int idDonacion { get; set; }
        public int idPobreza { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public string cantidad { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fecha_recojo { get; set; }
        public int idDonante { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
    
        public virtual Donante Donante { get; set; }
        public virtual Personas_extrema_pobreza Personas_extrema_pobreza { get; set; }
    }
}
