﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseApproach2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AvengersDbEntities : DbContext
    {
        public AvengersDbEntities()
            : base("name=AvengersDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    
        public virtual ObjectResult<sp_getEmployee_Result> sp_getEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getEmployee_Result>("sp_getEmployee");
        }
    }
}
