//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiThucHanh11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CHUCVU
    {
        [Key]
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public Nullable<double> PhuCap { get; set; }
    }
}
