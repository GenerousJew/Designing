﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewSession1Entities : DbContext
    {
        public NewSession1Entities()
            : base("name=NewSession1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Discussion> Discussion { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<StatusHistory> StatusHistory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
    }
}