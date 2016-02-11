namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minorchange : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Roles", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Resources", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Assignments", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Projects", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.ChangeRequests", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.ClientInfoes", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Permissions", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.RoleGroups", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.StepManagers", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.TaskGroups", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.TaskTypes", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Tasks", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.TaskManagers", name: "UpdatedBy_Id", newName: "ModifiedBy_Id");
            RenameIndex(table: "dbo.Assignments", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Roles", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.StepManagers", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_UpdatedBy_Id", newName: "IX_ModifiedBy_Id");
            AddColumn("dbo.Teams", "ModifiedBy_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Teams", "ModifiedBy_Id");
            AddForeignKey("dbo.Teams", "ModifiedBy_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "ModifiedBy_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Teams", new[] { "ModifiedBy_Id" });
            DropColumn("dbo.Teams", "ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.StepManagers", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Roles", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Assignments", name: "IX_ModifiedBy_Id", newName: "IX_UpdatedBy_Id");
            RenameColumn(table: "dbo.TaskManagers", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Tasks", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.TaskTypes", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.TaskGroups", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.StepManagers", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.RoleGroups", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Permissions", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.ClientInfoes", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.ChangeRequests", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Projects", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Assignments", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Resources", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Roles", name: "ModifiedBy_Id", newName: "UpdatedBy_Id");
        }
    }
}
