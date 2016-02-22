namespace Core.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtables_todo_dept_Desig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Roles", newName: "TaskRoles");
            RenameColumn(table: "dbo.Resources", name: "Team_Id", newName: "TeamId");
            RenameColumn(table: "dbo.Resources", name: "ActualRole_Id", newName: "TaskRoleId");
            RenameIndex(table: "dbo.Resources", name: "IX_Team_Id", newName: "IX_TeamId");
            RenameIndex(table: "dbo.Resources", name: "IX_ActualRole_Id", newName: "IX_TaskRoleId");
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ToDoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        ToDoTask = c.String(),
                        Description = c.String(),
                        TargetDate = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                        ProjectId = c.Int(),
                        CreatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId)
                .Index(t => t.ProjectId)
                .Index(t => t.CreatedBy_Id);
            
            AddColumn("dbo.Resources", "UserInfoId", c => c.Int(nullable: false));
            AddColumn("dbo.Resources", "DesignationId", c => c.Int());
            CreateIndex("dbo.Resources", "DesignationId");
            AddForeignKey("dbo.Resources", "DesignationId", "dbo.Designations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoes", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ToDoes", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Resources", "DesignationId", "dbo.Designations");
            DropIndex("dbo.ToDoes", new[] { "CreatedBy_Id" });
            DropIndex("dbo.ToDoes", new[] { "ProjectId" });
            DropIndex("dbo.Resources", new[] { "DesignationId" });
            DropColumn("dbo.Resources", "DesignationId");
            DropColumn("dbo.Resources", "UserInfoId");
            DropTable("dbo.ToDoes");
            DropTable("dbo.Departments");
            DropTable("dbo.Designations");
            RenameIndex(table: "dbo.Resources", name: "IX_TaskRoleId", newName: "IX_ActualRole_Id");
            RenameIndex(table: "dbo.Resources", name: "IX_TeamId", newName: "IX_Team_Id");
            RenameColumn(table: "dbo.Resources", name: "TaskRoleId", newName: "ActualRole_Id");
            RenameColumn(table: "dbo.Resources", name: "TeamId", newName: "Team_Id");
            RenameTable(name: "dbo.TaskRoles", newName: "Roles");
        }
    }
}
