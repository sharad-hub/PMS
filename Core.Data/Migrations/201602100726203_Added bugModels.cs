namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedbugModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Permissions", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tasks", "AllowedGroup_Id", "dbo.RoleGroups");
            DropForeignKey("dbo.Tasks", "TaskGroup_Id", "dbo.TaskGroups");
            DropIndex("dbo.Permissions", new[] { "User_Id" });
            DropIndex("dbo.Tasks", new[] { "AllowedGroup_Id" });
            DropIndex("dbo.Tasks", new[] { "TaskGroup_Id" });
            CreateTable(
                "dbo.ContactTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccessLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Order = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        AllowedGroup_Id = c.Int(),
                        CreatedBy_Id = c.String(maxLength: 128),
                        UpdatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoleGroups", t => t.AllowedGroup_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.AllowedGroup_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            AddColumn("dbo.AspNetUsers", "IsApproved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Resources", "ActualRole_Id", c => c.Int());
            AddColumn("dbo.ContactDetails", "Order", c => c.Int(nullable: false));
            AddColumn("dbo.ContactDetails", "Type_Id", c => c.Int());
            AddColumn("dbo.ContactDetails", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Permissions", "AreaName", c => c.String());
            AddColumn("dbo.Permissions", "ControllerName", c => c.String());
            AddColumn("dbo.Permissions", "ActionName", c => c.String());
            AddColumn("dbo.Permissions", "AccessLevel_Id", c => c.Int());
            AddColumn("dbo.Roles", "Resource_Id", c => c.Int());
            AddColumn("dbo.Roles", "Permission_Id", c => c.Int());
            AddColumn("dbo.Tasks", "TimeInHrs", c => c.Int(nullable: false));
            AddColumn("dbo.Tasks", "AssignedTo_Id", c => c.Int());
            AddColumn("dbo.Tasks", "TaskType_Id", c => c.Int());
            CreateIndex("dbo.ContactDetails", "Type_Id");
            CreateIndex("dbo.ContactDetails", "ApplicationUser_Id");
            CreateIndex("dbo.Resources", "ActualRole_Id");
            CreateIndex("dbo.Roles", "Resource_Id");
            CreateIndex("dbo.Roles", "Permission_Id");
            CreateIndex("dbo.Permissions", "AccessLevel_Id");
            CreateIndex("dbo.Tasks", "AssignedTo_Id");
            CreateIndex("dbo.Tasks", "TaskType_Id");
            AddForeignKey("dbo.ContactDetails", "Type_Id", "dbo.ContactTypes", "Id");
            AddForeignKey("dbo.ContactDetails", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Resources", "ActualRole_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Roles", "Resource_Id", "dbo.Resources", "Id");
            AddForeignKey("dbo.Permissions", "AccessLevel_Id", "dbo.AccessLevels", "Id");
            AddForeignKey("dbo.Roles", "Permission_Id", "dbo.Permissions", "Id");
            AddForeignKey("dbo.Tasks", "AssignedTo_Id", "dbo.Resources", "Id");
            AddForeignKey("dbo.Tasks", "TaskType_Id", "dbo.TaskTypes", "Id");
            DropColumn("dbo.ContactDetails", "Type");
            DropColumn("dbo.Permissions", "User_Id");
            DropColumn("dbo.Tasks", "TaskOrder");
            DropColumn("dbo.Tasks", "AllowedGroup_Id");
            DropColumn("dbo.Tasks", "TaskGroup_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "TaskGroup_Id", c => c.Int());
            AddColumn("dbo.Tasks", "AllowedGroup_Id", c => c.Int());
            AddColumn("dbo.Tasks", "TaskOrder", c => c.Int(nullable: false));
            AddColumn("dbo.Permissions", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.ContactDetails", "Type", c => c.String());
            DropForeignKey("dbo.Tasks", "TaskType_Id", "dbo.TaskTypes");
            DropForeignKey("dbo.TaskTypes", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TaskTypes", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TaskTypes", "AllowedGroup_Id", "dbo.RoleGroups");
            DropForeignKey("dbo.Tasks", "AssignedTo_Id", "dbo.Resources");
            DropForeignKey("dbo.Roles", "Permission_Id", "dbo.Permissions");
            DropForeignKey("dbo.Permissions", "AccessLevel_Id", "dbo.AccessLevels");
            DropForeignKey("dbo.Roles", "Resource_Id", "dbo.Resources");
            DropForeignKey("dbo.Resources", "ActualRole_Id", "dbo.Roles");
            DropForeignKey("dbo.ContactDetails", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ContactDetails", "Type_Id", "dbo.ContactTypes");
            DropIndex("dbo.TaskTypes", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.TaskTypes", new[] { "CreatedBy_Id" });
            DropIndex("dbo.TaskTypes", new[] { "AllowedGroup_Id" });
            DropIndex("dbo.Tasks", new[] { "TaskType_Id" });
            DropIndex("dbo.Tasks", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Permissions", new[] { "AccessLevel_Id" });
            DropIndex("dbo.Roles", new[] { "Permission_Id" });
            DropIndex("dbo.Roles", new[] { "Resource_Id" });
            DropIndex("dbo.Resources", new[] { "ActualRole_Id" });
            DropIndex("dbo.ContactDetails", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ContactDetails", new[] { "Type_Id" });
            DropColumn("dbo.Tasks", "TaskType_Id");
            DropColumn("dbo.Tasks", "AssignedTo_Id");
            DropColumn("dbo.Tasks", "TimeInHrs");
            DropColumn("dbo.Roles", "Permission_Id");
            DropColumn("dbo.Roles", "Resource_Id");
            DropColumn("dbo.Permissions", "AccessLevel_Id");
            DropColumn("dbo.Permissions", "ActionName");
            DropColumn("dbo.Permissions", "ControllerName");
            DropColumn("dbo.Permissions", "AreaName");
            DropColumn("dbo.ContactDetails", "ApplicationUser_Id");
            DropColumn("dbo.ContactDetails", "Type_Id");
            DropColumn("dbo.ContactDetails", "Order");
            DropColumn("dbo.Resources", "ActualRole_Id");
            DropColumn("dbo.AspNetUsers", "IsApproved");
            DropTable("dbo.TaskTypes");
            DropTable("dbo.AccessLevels");
            DropTable("dbo.ContactTypes");
            CreateIndex("dbo.Tasks", "TaskGroup_Id");
            CreateIndex("dbo.Tasks", "AllowedGroup_Id");
            CreateIndex("dbo.Permissions", "User_Id");
            AddForeignKey("dbo.Tasks", "TaskGroup_Id", "dbo.TaskGroups", "Id");
            AddForeignKey("dbo.Tasks", "AllowedGroup_Id", "dbo.RoleGroups", "Id");
            AddForeignKey("dbo.Permissions", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
