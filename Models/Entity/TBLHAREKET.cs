//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCKutuphane.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLHAREKET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLHAREKET()
        {
            this.TBLCEZALAR = new HashSet<TBLCEZALAR>();
        }
    
        public int ID { get; set; }
        public Nullable<int> KITAP { get; set; }
        public Nullable<int> UYE { get; set; }
        public Nullable<byte> PERSONEL { get; set; }
        public Nullable<System.DateTime> ALISTARIH { get; set; }
        public Nullable<System.DateTime> IADETARIH { get; set; }
        public Nullable<bool> ISLEMDURUM { get; set; }
        public Nullable<System.DateTime> UYEGETIRTARIH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCEZALAR> TBLCEZALAR { get; set; }
        public virtual TBLKITAP TBLKITAP { get; set; }
        public virtual TBLUYELER TBLUYELER { get; set; }
    }
}
