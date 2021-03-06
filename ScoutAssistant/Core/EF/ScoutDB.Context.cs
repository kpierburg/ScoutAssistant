﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoutAssistant.Core.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScoutDB : DbContext
    {
        public ScoutDB()
            : base("name=ScoutDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Association> Associations { get; set; }
        public virtual DbSet<BowlGame> BowlGames { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<SchoolPersonnel> SchoolPersonnels { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<ScoutAssignment> ScoutAssignments { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<vwSchoolPersonnelList> vwSchoolPersonnelLists { get; set; }
        public virtual DbSet<Scout> Scouts { get; set; }
        public virtual DbSet<vwSchoolFullList> vwSchoolFullLists { get; set; }
        public virtual DbSet<vwSchoolPartialList> vwSchoolPartialLists { get; set; }
        public virtual DbSet<vwSchoolPlayerList> vwSchoolPlayerLists { get; set; }
    }
}
