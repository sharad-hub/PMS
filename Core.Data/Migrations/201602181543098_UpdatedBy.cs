namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedBy : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Assignments", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Roles", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Resources", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Teams", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.ChangeRequests", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Projects", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.ClientInfoes", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Permissions", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.RoleGroups", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.StepManagers", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.TaskGroups", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.Tasks", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.TaskTypes", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameColumn(table: "dbo.TaskManagers", name: "CreatedBy_Id", newName: "CreatedByUser_Id");
            RenameIndex(table: "dbo.Assignments", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Roles", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Teams", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.StepManagers", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_CreatedBy_Id", newName: "IX_CreatedByUser_Id");
            CreateTable(
                "dbo.Bugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.Int(nullable: false),
                        AssignedOn = c.DateTime(nullable: false),
                        FixedOn = c.DateTime(nullable: false),
                        TimeTakenToFix = c.Int(nullable: false),
                        AssignedTo_Id = c.Int(),
                        BugType_Id = c.Int(),
                        ChangeRequest_Id = c.Int(),
                        RaisedBy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resources", t => t.AssignedTo_Id)
                .ForeignKey("dbo.BugTypes", t => t.BugType_Id)
                .ForeignKey("dbo.ChangeRequests", t => t.ChangeRequest_Id)
                .ForeignKey("dbo.Resources", t => t.RaisedBy_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.BugType_Id)
                .Index(t => t.ChangeRequest_Id)
                .Index(t => t.RaisedBy_Id);
            
            CreateTable(
                "dbo.BugTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MileStones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AssignedTo_Id = c.Int(),
                        ChangeRequest_Id = c.Int(),
                        CreatedByUser_Id = c.String(maxLength: 128),
                        ModifiedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resources", t => t.AssignedTo_Id)
                .ForeignKey("dbo.ChangeRequests", t => t.ChangeRequest_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedByUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ModifiedBy_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.ChangeRequest_Id)
                .Index(t => t.CreatedByUser_Id)
                .Index(t => t.ModifiedBy_Id);
            
            CreateTable(
                "dbo.WorkBreakDownStructures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        ChangeRequest_Id = c.Int(),
                        CreatedByUser_Id = c.String(maxLength: 128),
                        ModifiedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChangeRequests", t => t.ChangeRequest_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedByUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ModifiedBy_Id)
                .Index(t => t.ChangeRequest_Id)
                .Index(t => t.CreatedByUser_Id)
                .Index(t => t.ModifiedBy_Id);
            
            AddColumn("dbo.Projects", "ProjectType_Id", c => c.Int());
            AddColumn("dbo.Tasks", "WorkBreakDownStructure_Id", c => c.Int());
            CreateIndex("dbo.Projects", "ProjectType_Id");
            CreateIndex("dbo.Tasks", "WorkBreakDownStructure_Id");
            AddForeignKey("dbo.Projects", "ProjectType_Id", "dbo.ProjectTypes", "Id");
            AddForeignKey("dbo.Tasks", "WorkBreakDownStructure_Id", "dbo.WorkBreakDownStructures", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "WorkBreakDownStructure_Id", "dbo.WorkBreakDownStructures");
            DropForeignKey("dbo.WorkBreakDownStructures", "ModifiedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.WorkBreakDownStructures", "CreatedByUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.WorkBreakDownStructures", "ChangeRequest_Id", "dbo.ChangeRequests");
            DropForeignKey("dbo.MileStones", "ModifiedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.MileStones", "CreatedByUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.MileStones", "ChangeRequest_Id", "dbo.ChangeRequests");
            DropForeignKey("dbo.MileStones", "AssignedTo_Id", "dbo.Resources");
            DropForeignKey("dbo.Bugs", "RaisedBy_Id", "dbo.Resources");
            DropForeignKey("dbo.Bugs", "ChangeRequest_Id", "dbo.ChangeRequests");
            DropForeignKey("dbo.Projects", "ProjectType_Id", "dbo.ProjectTypes");
            DropForeignKey("dbo.Bugs", "BugType_Id", "dbo.BugTypes");
            DropForeignKey("dbo.Bugs", "AssignedTo_Id", "dbo.Resources");
            DropIndex("dbo.WorkBreakDownStructures", new[] { "ModifiedBy_Id" });
            DropIndex("dbo.WorkBreakDownStructures", new[] { "CreatedByUser_Id" });
            DropIndex("dbo.WorkBreakDownStructures", new[] { "ChangeRequest_Id" });
            DropIndex("dbo.Tasks", new[] { "WorkBreakDownStructure_Id" });
            DropIndex("dbo.MileStones", new[] { "ModifiedBy_Id" });
            DropIndex("dbo.MileStones", new[] { "CreatedByUser_Id" });
            DropIndex("dbo.MileStones", new[] { "ChangeRequest_Id" });
            DropIndex("dbo.MileStones", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Projects", new[] { "ProjectType_Id" });
            DropIndex("dbo.Bugs", new[] { "RaisedBy_Id" });
            DropIndex("dbo.Bugs", new[] { "ChangeRequest_Id" });
            DropIndex("dbo.Bugs", new[] { "BugType_Id" });
            DropIndex("dbo.Bugs", new[] { "AssignedTo_Id" });
            DropColumn("dbo.Tasks", "WorkBreakDownStructure_Id");
            DropColumn("dbo.Projects", "ProjectType_Id");
            DropTable("dbo.WorkBreakDownStructures");
            DropTable("dbo.MileStones");
            DropTable("dbo.ProjectTypes");
            DropTable("dbo.BugTypes");
            DropTable("dbo.Bugs");
            RenameIndex(table: "dbo.TaskManagers", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.TaskTypes", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.TaskGroups", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.StepManagers", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.RoleGroups", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Permissions", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.ClientInfoes", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.ChangeRequestTypes", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.ChangeRequests", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Teams", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Roles", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Assignments", name: "IX_CreatedByUser_Id", newName: "IX_CreatedBy_Id");
            RenameColumn(table: "dbo.TaskManagers", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.TaskTypes", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Tasks", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.TaskGroups", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.StepManagers", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.RoleGroups", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Permissions", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.ClientInfoes", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.ChangeRequestTypes", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Projects", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.ChangeRequests", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Teams", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Resources", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Roles", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Assignments", name: "CreatedByUser_Id", newName: "CreatedBy_Id");
        }
    }
}
