//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTTraSach
    {
        public int Ma { get; set; }
        public int MaTS { get; set; }
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
    
        public virtual Sach Sach { get; set; }
        public virtual TraSach TraSach { get; set; }
    }
}