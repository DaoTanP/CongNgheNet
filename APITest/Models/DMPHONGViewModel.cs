using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITest.Models
{
    public class DMPHONGViewModel
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public ICollection<DSNVViewModel> DSNV { get; set; }
    }
}