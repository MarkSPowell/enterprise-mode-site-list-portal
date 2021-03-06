﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMIEWebPortal.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LOBMergedEntities : DbContext
    {
        public LOBMergedEntities()
            : base("name=LOBMergedEntities")
        {
            var adapter = (IObjectContextAdapter)this;
            var objectContext = adapter.ObjectContext;
            objectContext.CommandTimeout = 1 * 180; 
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApplicationAppTypeMapping> ApplicationAppTypeMappings { get; set; }
        public virtual DbSet<ApplicationDetail> ApplicationDetails { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationState> ApplicationStates { get; set; }
        public virtual DbSet<AppOnboardDetail> AppOnboardDetails { get; set; }
        public virtual DbSet<AppTechnologyMapping> AppTechnologyMappings { get; set; }
        public virtual DbSet<AppType> AppTypes { get; set; }
        public virtual DbSet<AppUrlMapping> AppUrlMappings { get; set; }
        public virtual DbSet<BPU> BPUs { get; set; }
        public virtual DbSet<DemoScheduler> DemoSchedulers { get; set; }
        public virtual DbSet<DocMode> DocModes { get; set; }
        public virtual DbSet<EMIEChangeType> EMIEChangeTypes { get; set; }
        public virtual DbSet<EMIEReasonForChange> EMIEReasonForChanges { get; set; }
        public virtual DbSet<EMIETicket> EMIETickets { get; set; }
        public virtual DbSet<EMIETicketState> EMIETicketStates { get; set; }
        public virtual DbSet<EMIETicketStatu> EMIETicketStatus { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Environment> Environments { get; set; }
        public virtual DbSet<IssueType> IssueTypes { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<NoOfUser> NoOfUsers { get; set; }
        public virtual DbSet<ProjectCategory> ProjectCategories { get; set; }
        public virtual DbSet<ResultType> ResultTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<TestPass> TestPasses { get; set; }
        public virtual DbSet<TestPassPrimSecMapping> TestPassPrimSecMappings { get; set; }
        public virtual DbSet<TestPassTechnologyMapping> TestPassTechnologyMappings { get; set; }
        public virtual DbSet<TestPassToTypeMapping> TestPassToTypeMappings { get; set; }
        public virtual DbSet<TestPassType> TestPassTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PrimSecCriteria> PrimSecCriterias { get; set; }
        public virtual DbSet<SubResult> SubResults { get; set; }
        public virtual DbSet<TestResult> TestResults { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<TM_APIDetails> TM_APIDetails { get; set; }
        public virtual DbSet<TM_BrowserStateReason> TM_BrowserStateReason { get; set; }
        public virtual DbSet<TM_DocModeReason> TM_DocModeReason { get; set; }
        public virtual DbSet<TM_Domain> TM_Domain { get; set; }
        public virtual DbSet<TM_TelemetryData> TM_TelemetryData { get; set; }
        public virtual DbSet<UserRoleBPUMapping> UserRoleBPUMappings { get; set; }
        public virtual DbSet<EMIETicketAproval> EMIETicketAprovals { get; set; }
        public virtual DbSet<EMIETicketsArch> EMIETicketsArches { get; set; }
        public virtual DbSet<EMIEConfiguration> EMIEConfigurations { get; set; }
        public virtual DbSet<EMIEConfigurationSetting> EMIEConfigurationSettings { get; set; }
    }
}
