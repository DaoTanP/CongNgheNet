using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITest.Models
{
    public class DSNVViewModel
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string MaPhong { get; set; }
        public string MaChucVu { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public DMPHONGViewModel DMPHONG { get; set; }
        public CHUCVUViewModel CHUCVU { get; set; }
    }
}