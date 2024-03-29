namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedisAplicationUserId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Assignments", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Assignments", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.Resources", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Resources", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.Roles", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Roles", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.Teams", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Teams", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.ChangeRequests", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.ChangeRequests", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.Projects", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Projects", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.ClientInfoes", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.ClientInfoes", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.MileStones", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.MileStones", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.Permissions", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Permissions", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.RoleGroups", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.RoleGroups", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.StepManagers", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.StepManagers", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.TaskGroups", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.TaskGroups", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.Tasks", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.Tasks", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.TaskTypes", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.TaskTypes", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.TaskManagers", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.TaskManagers", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameColumn(table: "dbo.WorkBreakDownStructures", name: "CreatedByUser_Id", newName: "CreatedByUserId");
            RenameColumn(table: "dbo.WorkBreakDownStructures", name: "ModifiedBy_Id", newName: "ModifiedById");
            RenameIndex(table: "dbo.Assignments", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Assignments", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.Resources", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Resources", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.Roles", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Roles", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.Teams", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Teams", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.Projects", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Projects", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.MileStones", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.MileStones", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.Permissions", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Permissions", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.StepManagers", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.StepManagers", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.Tasks", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.Tasks", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
            RenameIndex(table: "dbo.WorkBreakDownStructures", name: "IX_CreatedByUser_Id", newName: "IX_CreatedByUserId");
            RenameIndex(table: "dbo.WorkBreakDownStructures", name: "IX_ModifiedBy_Id", newName: "IX_ModifiedById");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.WorkBreakDownStructures", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.WorkBreakDownStructures", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.StepManagers", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.StepManagers", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.MileStones", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.MileStones", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Teams", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Teams", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Roles", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Roles", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Assignments", name: "IX_ModifiedById", newName: "IX_ModifiedBy_Id");
            RenameIndex(table: "dbo.Assignments", name: "IX_CreatedByUserId", newName: "IX_CreatedByUser_Id");
            RenameColumn(table: "dbo.WorkBreakDownStructures", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.WorkBreakDownStructures", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.TaskManagers", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.TaskManagers", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.TaskTypes", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.TaskTypes", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Tasks", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Tasks", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.TaskGroups", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.TaskGroups", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.StepManagers", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.StepManagers", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.RoleGroups", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.RoleGroups", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Permissions", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Permissions", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.MileStones", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.MileStones", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.ClientInfoes", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.ClientInfoes", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Projects", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Projects", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.ChangeRequests", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.ChangeRequests", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Teams", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Teams", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Roles", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Roles", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Resources", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Resources", name: "CreatedByUserId", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Assignments", name: "ModifiedById", newName: "ModifiedBy_Id");
            RenameColumn(table: "dbo.Assignments", name: "CreatedByUserId", newName: "CreatedByUser_Id");
        }
    }
}
