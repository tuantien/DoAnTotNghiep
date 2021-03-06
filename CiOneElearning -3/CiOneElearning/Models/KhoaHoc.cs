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
    
    public partial class KhoaHoc
    {
        public KhoaHoc()
        {
            this.BaiGiangs = new HashSet<BaiGiang>();
            this.HocViens = new HashSet<HocVien>();
        }
    
        public int ID_KhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }
        public string ThoiLuong { get; set; }
        public string MoTaNgan { get; set; }
        public string GioiThieu { get; set; }
        public Nullable<System.DateTime> NgayMoKH { get; set; }
        public Nullable<int> ID_TacGia { get; set; }
        public string Hello { get; set; }
    
        public virtual ICollection<BaiGiang> BaiGiangs { get; set; }
        public virtual ICollection<HocVien> HocViens { get; set; }
        public virtual TacGia TacGia { get; set; }
    }
}
