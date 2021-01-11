//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoyectoGuiasTuristicos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta()
        {
            this.ReservaOrganizaRuta = new HashSet<ReservaOrganizaRuta>();
        }
    
        public int id { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFinal { get; set; }
        public string lugar_quedada { get; set; }
        public int plazas { get; set; }
        public string descripcion { get; set; }
        public string fotografia { get; set; }
        public int precio { get; set; }
        public int ciudad_id { get; set; }
        public int guia_id { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaOrganizaRuta> ReservaOrganizaRuta { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}