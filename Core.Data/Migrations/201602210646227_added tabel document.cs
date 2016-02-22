namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtabeldocument : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedByUserId = c.String(maxLength: 128),
                        ModifiedById = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        IsArchieved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedByUserId)
                .ForeignKey("dbo.AspNetUsers", t => t.ModifiedById)
                .Index(t => t.CreatedByUserId)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.DocumentVersions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VersionNumber = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        VersionedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.VersionedBy_Id)
                .Index(t => t.VersionedBy_Id);
            
            AlterColumn("dbo.Assignments", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Resources", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.TaskRoles", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Teams", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.ChangeRequests", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Projects", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.ChangeRequestTypes", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.ClientInfoes", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.MileStones", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Permissions", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.RoleGroups", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.StepManagers", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.TaskGroups", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Tasks", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.TaskTypes", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.TaskManagers", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.WorkBreakDownStructures", "UpdatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentVersions", "VersionedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Documents", "ModifiedById", "dbo.AspNetUsers");
            DropForeignKey("dbo.Documents", "CreatedByUserId", "dbo.AspNetUsers");
            DropIndex("dbo.DocumentVersions", new[] { "VersionedBy_Id" });
            DropIndex("dbo.Documents", new[] { "ModifiedById" });
            DropIndex("dbo.Documents", new[] { "CreatedByUserId" });
            AlterColumn("dbo.WorkBreakDownStructures", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TaskManagers", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TaskTypes", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tasks", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TaskGroups", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StepManagers", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RoleGroups", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Permissions", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MileStones", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClientInfoes", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ChangeRequestTypes", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Projects", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ChangeRequests", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teams", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TaskRoles", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Resources", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Assignments", "UpdatedOn", c => c.DateTime(nullable: false));
            DropTable("dbo.DocumentVersions");
            DropTable("dbo.Documents");
        }
    }
}
