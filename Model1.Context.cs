﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Olympiad
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dcAirplane : DbContext
    {
        public dcAirplane()
            : base("name=dcAirplane")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AirPlane> AirPlane { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<Plane> Plane { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_companyPic> tbl_companyPic { get; set; }
        public virtual DbSet<tbl_employee> tbl_employee { get; set; }
        public virtual DbSet<tbl_Incorrectlogin> tbl_Incorrectlogin { get; set; }
        public virtual DbSet<tbl_log> tbl_log { get; set; }
        public virtual DbSet<tbl_Pilot> tbl_Pilot { get; set; }
        public virtual DbSet<tbl_planeMoreInfo> tbl_planeMoreInfo { get; set; }
        public virtual DbSet<tbl_Role> tbl_Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
    }
}