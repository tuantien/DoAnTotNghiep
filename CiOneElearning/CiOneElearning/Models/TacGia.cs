//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiOneElearning.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TacGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TacGia()
        {
            this.KhoaHocs = new HashSet<KhoaHoc>();
        }
    
        public int ID_TacGia { get; set; }
        public string TenTacGia { get; set; }
        public string ChucVi { get; set; }
        public string GioiThieuTG { get; set; }
        public string AnhTG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
