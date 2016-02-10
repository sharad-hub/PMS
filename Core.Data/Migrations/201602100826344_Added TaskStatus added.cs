namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTaskStatusadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Assignments", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Resources", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teams", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ChangeRequests", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Projects", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ChangeRequestTypes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClientInfoes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Permissions", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoleGroups", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.StepManagers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaskGroups", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tasks", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tasks", "TaskStatus_Id", c => c.Int());
            AddColumn("dbo.TaskTypes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaskManagers", "IsActive", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Tasks", "TaskStatus_Id");
            AddForeignKey("dbo.Tasks", "TaskStatus_Id", "dbo.TaskStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "TaskStatus_Id", "dbo.TaskStatus");
            DropIndex("dbo.Tasks", new[] { "TaskStatus_Id" });
            DropColumn("dbo.TaskManagers", "IsActive");
            DropColumn("dbo.TaskTypes", "IsActive");
            DropColumn("dbo.Tasks", "TaskStatus_Id");
            DropColumn("dbo.Tasks", "IsActive");
            DropColumn("dbo.TaskGroups", "IsActive");
            DropColumn("dbo.StepManagers", "IsActive");
            DropColumn("dbo.RoleGroups", "IsActive");
            DropColumn("dbo.Permissions", "IsActive");
            DropColumn("dbo.ClientInfoes", "IsActive");
            DropColumn("dbo.ChangeRequestTypes", "IsActive");
            DropColumn("dbo.Projects", "IsActive");
            DropColumn("dbo.ChangeRequests", "IsActive");
            DropColumn("dbo.Teams", "IsActive");
            DropColumn("dbo.Roles", "IsActive");
            DropColumn("dbo.Resources", "IsActive");
            DropColumn("dbo.Assignments", "IsActive");
            DropTable("dbo.TaskStatus");
        }
    }
}
