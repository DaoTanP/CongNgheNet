﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLNSEntities : DbContext
    {
        public QLNSEntities()
            : base("name=QLNSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DMPHONG> DMPHONGs { get; set; }
        public virtual DbSet<DSNV> DSNVs { get; set; }
    }
}
