﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTHUCHIEntities : DbContext
    {
        public QLTHUCHIEntities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<KHOANCHI> KHOANCHIs { get; set; }
        public virtual DbSet<KHOANTHU> KHOANTHUs { get; set; }
        public virtual DbSet<LOAIKHOANCHI> LOAIKHOANCHIs { get; set; }
        public virtual DbSet<LOAIKHOANTHU> LOAIKHOANTHUs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
