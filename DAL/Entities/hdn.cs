//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class hdn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hdn()
        {
            this.chitiethdns = new HashSet<chitiethdn>();
        }
    
        public string mahdn { get; set; }
        public Nullable<System.DateTime> ngayNhap { get; set; }
        public string manv { get; set; }
        public string mancc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethdn> chitiethdns { get; set; }
        public virtual ncc ncc { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}