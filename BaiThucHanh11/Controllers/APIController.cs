using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaiThucHanh11.Models;

namespace BaiThucHanh11.Controllers
{
    public class APIController : ApiController
    {
        [HttpGet]
        [Route("dsnv/get")]
        public IHttpActionResult GetDSNV()
        {
            IList<DSNV> ds;

            var context = new QLNSEntities();
            if(context.DSNVs.ElementAt(0) == null)
            {
                return NotFound();
            }

            ds = context.DSNVs.Select(nv => new DSNV()
            {
                MaNV = nv.MaNV,
                HoTen = nv.HoTen,
                GioiTinh = nv.GioiTinh,
                NgaySinh = nv.NgaySinh,
                MaPhong =  nv.MaPhong,
                MaChucVu = nv.MaChucVu,
                HeSoLuong = nv.HeSoLuong
            }).ToList();

            return Ok(ds);
        }

        [HttpPost]
        [Route("dsnv/get")]
        public IHttpActionResult PostNV(DSNV nv)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            var context = new QLNSEntities();
            context.DSNVs.Add(nv);
            context.SaveChanges();
            return Ok();
        }

        public IEnumerable<DSNV> Get()
        {
            var context = new QLNSEntities();
            if (context.DSNVs.ElementAt(0) == null)
            {
                return null;
            }
            IList<DSNV> ds = context.DSNVs.Select(nv => new DSNV()
            {
                MaNV = nv.MaNV,
                HoTen = nv.HoTen,
                GioiTinh = nv.GioiTinh,
                NgaySinh = nv.NgaySinh,
                MaPhong = nv.MaPhong,
                MaChucVu = nv.MaChucVu,
                HeSoLuong = nv.HeSoLuong
            }).ToList();

            return ds;
        }
    }
}
