//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouringShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Giohang
    {
        public int ID_GH { get; set; }
        public Nullable<int> ID_KH { get; set; }
        public Nullable<int> ID_SP { get; set; }
        public int Soluongtronggiohang { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}