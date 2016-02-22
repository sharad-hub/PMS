namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedisarchved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Resources", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teams", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.ChangeRequests", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Projects", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.ChangeRequestTypes", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClientInfoes", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.MileStones", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Permissions", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoleGroups", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.StepManagers", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaskGroups", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tasks", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaskTypes", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.TaskManagers", "IsArchieved", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkBreakDownStructures", "IsArchieved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkBreakDownStructures", "IsArchieved");
            DropColumn("dbo.TaskManagers", "IsArchieved");
            DropColumn("dbo.TaskTypes", "IsArchieved");
            DropColumn("dbo.Tasks", "IsArchieved");
            DropColumn("dbo.TaskGroups", "IsArchieved");
            DropColumn("dbo.StepManagers", "IsArchieved");
            DropColumn("dbo.RoleGroups", "IsArchieved");
            DropColumn("dbo.Permissions", "IsArchieved");
            DropColumn("dbo.MileStones", "IsArchieved");
            DropColumn("dbo.ClientInfoes", "IsArchieved");
            DropColumn("dbo.ChangeRequestTypes", "IsArchieved");
            DropColumn("dbo.Projects", "IsArchieved");
            DropColumn("dbo.ChangeRequests", "IsArchieved");
            DropColumn("dbo.Teams", "IsArchieved");
            DropColumn("dbo.Roles", "IsArchieved");
            DropColumn("dbo.Resources", "IsArchieved");
            DropColumn("dbo.Assignments", "IsArchieved");
        }
    }
}
