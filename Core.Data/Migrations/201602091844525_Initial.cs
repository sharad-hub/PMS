namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskName = c.String(),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        Resource_Id = c.Int(),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Resources", t => t.Resource_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Resource_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreatedOn = c.DateTime(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        Team_Id = c.Int(),
                        UpdatedBy_Id = c.String(maxLength: 128),
                        UserInfo_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserInfo_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.UpdatedBy_Id)
                .Index(t => t.UserInfo_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.DateTime(nullable: false),
                        Description = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        CreatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .Index(t => t.CreatedBy_Id);
            
            CreateTable(
                "dbo.ChangeRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        CreatedBy_Id = c.String(maxLength: 128),
                        Project_Id = c.Int(),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Project_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.ChangeRequestTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OtherProperties = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                        StepManager_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .ForeignKey("dbo.StepManagers", t => t.StepManager_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id)
                .Index(t => t.StepManager_Id);
            
            CreateTable(
                "dbo.ClientInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.ContactPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClientInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientInfoes", t => t.ClientInfo_Id)
                .Index(t => t.ClientInfo_Id);
            
            CreateTable(
                "dbo.ContactDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Value = c.String(),
                        ContactPerson_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactPersons", t => t.ContactPerson_Id)
                .Index(t => t.ContactPerson_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.RoleGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                        RoleGroup_Id = c.Int(),
                        StepManager_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .ForeignKey("dbo.RoleGroups", t => t.RoleGroup_Id)
                .ForeignKey("dbo.StepManagers", t => t.StepManager_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id)
                .Index(t => t.RoleGroup_Id)
                .Index(t => t.StepManager_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.StepManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Controller = c.String(),
                        Action = c.String(),
                        OrderOfStep = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.TaskGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        ChangeRequestType_Id = c.Int(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChangeRequestTypes", t => t.ChangeRequestType_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.ChangeRequestType_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TaskOrder = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        AllowedGroup_Id = c.Int(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        TaskGroup_Id = c.Int(),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoleGroups", t => t.AllowedGroup_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.TaskGroups", t => t.TaskGroup_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.AllowedGroup_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.TaskGroup_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.TaskManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskManagers", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TaskManagers", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tasks", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tasks", "TaskGroup_Id", "dbo.TaskGroups");
            DropForeignKey("dbo.Tasks", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tasks", "AllowedGroup_Id", "dbo.RoleGroups");
            DropForeignKey("dbo.TaskGroups", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TaskGroups", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TaskGroups", "ChangeRequestType_Id", "dbo.ChangeRequestTypes");
            DropForeignKey("dbo.StepManagers", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.StepManagers", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Roles", "StepManager_Id", "dbo.StepManagers");
            DropForeignKey("dbo.ChangeRequestTypes", "StepManager_Id", "dbo.StepManagers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.RoleGroups", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Roles", "RoleGroup_Id", "dbo.RoleGroups");
            DropForeignKey("dbo.Roles", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Roles", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.RoleGroups", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Permissions", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Permissions", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Permissions", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ClientInfoes", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ClientInfoes", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ContactPersons", "ClientInfo_Id", "dbo.ClientInfoes");
            DropForeignKey("dbo.ContactDetails", "ContactPerson_Id", "dbo.ContactPersons");
            DropForeignKey("dbo.ChangeRequestTypes", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ChangeRequestTypes", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ChangeRequests", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ChangeRequests", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Projects", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Projects", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ChangeRequests", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Assignments", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Assignments", "Resource_Id", "dbo.Resources");
            DropForeignKey("dbo.Resources", "UserInfo_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Resources", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Resources", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Resources", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Assignments", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.TaskManagers", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.TaskManagers", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Tasks", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Tasks", new[] { "TaskGroup_Id" });
            DropIndex("dbo.Tasks", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Tasks", new[] { "AllowedGroup_Id" });
            DropIndex("dbo.TaskGroups", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.TaskGroups", new[] { "CreatedBy_Id" });
            DropIndex("dbo.TaskGroups", new[] { "ChangeRequestType_Id" });
            DropIndex("dbo.StepManagers", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.StepManagers", new[] { "CreatedBy_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Roles", new[] { "StepManager_Id" });
            DropIndex("dbo.Roles", new[] { "RoleGroup_Id" });
            DropIndex("dbo.Roles", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Roles", new[] { "CreatedBy_Id" });
            DropIndex("dbo.RoleGroups", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.RoleGroups", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Permissions", new[] { "User_Id" });
            DropIndex("dbo.Permissions", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Permissions", new[] { "CreatedBy_Id" });
            DropIndex("dbo.ContactDetails", new[] { "ContactPerson_Id" });
            DropIndex("dbo.ContactPersons", new[] { "ClientInfo_Id" });
            DropIndex("dbo.ClientInfoes", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.ClientInfoes", new[] { "CreatedBy_Id" });
            DropIndex("dbo.ChangeRequestTypes", new[] { "StepManager_Id" });
            DropIndex("dbo.ChangeRequestTypes", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.ChangeRequestTypes", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Projects", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Projects", new[] { "CreatedBy_Id" });
            DropIndex("dbo.ChangeRequests", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.ChangeRequests", new[] { "Project_Id" });
            DropIndex("dbo.ChangeRequests", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Teams", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Resources", new[] { "UserInfo_Id" });
            DropIndex("dbo.Resources", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Resources", new[] { "Team_Id" });
            DropIndex("dbo.Resources", new[] { "CreatedBy_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Assignments", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Assignments", new[] { "Resource_Id" });
            DropIndex("dbo.Assignments", new[] { "CreatedBy_Id" });
            DropTable("dbo.TaskManagers");
            DropTable("dbo.Tasks");
            DropTable("dbo.TaskGroups");
            DropTable("dbo.StepManagers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.RoleGroups");
            DropTable("dbo.Permissions");
            DropTable("dbo.ContactDetails");
            DropTable("dbo.ContactPersons");
            DropTable("dbo.ClientInfoes");
            DropTable("dbo.ChangeRequestTypes");
            DropTable("dbo.Projects");
            DropTable("dbo.ChangeRequests");
            DropTable("dbo.Teams");
            DropTable("dbo.Resources");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Assignments");
        }
    }
}
