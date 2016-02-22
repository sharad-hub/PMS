using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Core.Entites.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Core.Data
{
    public class CoreDbContext : IdentityDbContext<ApplicationUser>
    {
        //  public PMSEntities() : base("StoreEntities") { }
        public CoreDbContext()
            : base("PMSEntities")
        {

        }
        public static CoreDbContext Create()
        {
            return new CoreDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AccessLevel> AccessLevels { get; set; }     
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<BugType> BugTypes { get; set; }
        public DbSet<ClientInfo> ClientsInfo { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<ChangeRequest> ChangeRequests { get; set; }
        public DbSet<ChangeRequestType> ChangeRequestTypes { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<MileStone> MileStones { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<TaskRole> PMSRoles { get; set; }
        public DbSet<RoleGroup> RoleGroups { get; set; }
        public DbSet<StepManager> StepsManager { get; set; }
        public DbSet<TaskGroup> TaskGroups { get; set; }
        //public DbSet<TaskManager> TasksManager { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }    
        public DbSet<WorkBreakDownStructure> WBS { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentVersion> DocVersions { get; set; } 
          public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
