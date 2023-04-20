using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APITest.Models;

namespace APITest.Controllers
{
    public class QLNSController : ApiController
    {
        public IHttpActionResult GetDSNV()
        {
            IList<DSNVViewModel> dsnv = null;
            var ctx = new QLNSEntities();
            dsnv = ctx.DSNVs.Include("DSNVDMPHONG").Select(s => new DSNVViewModel()
            {
                MaNV = s.MaNV,
                HoTen = s.HoTen,
                NgaySinh = s.NgaySinh,
                GioiTinh = s.GioiTinh,
                MaPhong = s.MaPhong,
                MaChucVu = s.MaChucVu,
                HeSoLuong = s.HeSoLuong
            }).ToList();

            if (dsnv.Count == 0)
                return NotFound();

            return Ok(dsnv);
        }

        public IHttpActionResult PostDSNV(DSNVViewModel nv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            var ctx = new QLNSEntities();
            ctx.DSNVs.Add(new DSNV()
            {
                MaNV = nv.MaNV,
                HoTen = nv.HoTen,
                NgaySinh = nv.NgaySinh,
                GioiTinh = nv.GioiTinh,
                MaPhong = nv.MaPhong,
                MaChucVu = nv.MaChucVu,
                HeSoLuong = nv.HeSoLuong
            });
            ctx.SaveChanges();
            return Ok();
        }
    }
}
