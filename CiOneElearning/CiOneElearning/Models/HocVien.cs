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
    
    public partial class HocVien
    {
        public int ID_HocVien { get; set; }
        public string TenHocVien { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public Nullable<int> ID_TrangThai { get; set; }
        public Nullable<System.DateTime> NgayThamGia { get; set; }
        public string AnhHocVien { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> ID_KhoaHoc { get; set; }
    
        public virtual KhoaHoc KhoaHoc { get; set; }
        public virtual TrangThai TrangThai { get; set; }
    }
}
